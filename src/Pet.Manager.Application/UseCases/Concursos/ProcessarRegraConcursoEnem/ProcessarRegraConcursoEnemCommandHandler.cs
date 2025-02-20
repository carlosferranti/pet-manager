using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Enem;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Utils;
using Anima.Inscricoes.Domain.Inscricoes;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;

public class ProcessarRegraConcursoEnemCommandHandler : ICommandHandler<ProcessarRegraConcursoEnemCommand, List<ConcursosPorOfertaDto>>
{
    private readonly IEnemService _enemService;
    private readonly ILogger<ProcessarRegraConcursoEnemCommandHandler> _logger;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private const string SituacaoPerfilEnem = "ATENDE";

    public ProcessarRegraConcursoEnemCommandHandler(
        IEnemService enemService,
        ILogger<ProcessarRegraConcursoEnemCommandHandler> logger,
        IInscricaoRepository inscricaoRepository,
        IConcursoRepository concursoRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IIntakeRepository intakeRepository,
        IMarcaRepository marcaRepository,
        IOfertaRepository ofertaRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IModalidadeRepository modalidadeRepository)
    {
        _enemService = enemService;
        _logger = logger;
        _inscricaoRepository = inscricaoRepository;
        _concursoRepository = concursoRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _intakeRepository = intakeRepository;
        _marcaRepository = marcaRepository;
        _ofertaRepository = ofertaRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _modalidadeRepository = modalidadeRepository;
    }

    public async Task<List<ConcursosPorOfertaDto>> Handle(ProcessarRegraConcursoEnemCommand request, CancellationToken cancellationToken)
    {
        try
        {
            bool possuiPerfilEnem;

            var classificacaoEnem = await _enemService.ObterClassificacaoEnemAsync(new ObterClassificacaoResquestDto()
            {
                Cpf = request.Cpf,
            });

            if (classificacaoEnem is null || classificacaoEnem.Criterios?.Exists(c => c.Atual) == false)
            {
                request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.EnemKey);
                return request.Concursos;
            }

            var criterioAtual = classificacaoEnem!.Criterios?.Find(c => c.Atual);

            possuiPerfilEnem = criterioAtual?.Situacao?.Descricao?.ToUpper() == SituacaoPerfilEnem;

            if (!possuiPerfilEnem)
            {
                request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.EnemKey);
            }
            else if(!(await PossuiInscricaoEnemPraMesmaModalidadeAsync(request.MarcaKey, request.IntakeKey, request.Cpf, request.ModalidadeKey)))
            {
                request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.EntradaSimplificadaKey);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao processar regra de concurso ENEM. {@Request}", request);
        }
        
        return request.Concursos;
    }

    public virtual async Task<bool> PossuiInscricaoEnemPraMesmaModalidadeAsync(Guid marcaKey, Guid intakeKey, string cpf, Guid modalidadeKey)
    {
        var cpfSemFormatacao = CpfFormater.RemoverFormatacao(cpf);

        var query = from inscricao in _inscricaoRepository.GetQueryable().AsNoTracking()
                    join ofertaConcurso in _ofertaConcursoRepository.GetQueryable().AsNoTracking()
                        on inscricao.Oferta.OfertaConcursoId equals ofertaConcurso.Id
                    join oferta in _ofertaRepository.GetQueryable().AsNoTracking()
                        on inscricao.Oferta.OfertaId equals oferta.Id
                    join concurso in _concursoRepository.GetQueryable().AsNoTracking()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    join intake in _intakeRepository.GetQueryable().AsNoTracking()
                        on oferta.IntakeId equals intake.Id
                    join marca in _marcaRepository.GetQueryable().AsNoTracking()
                        on inscricao.MarcaId equals marca.Id
                    from inscricaoFormaEntrada in inscricao.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable().AsNoTracking()
                        on inscricaoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                    from modalidadeConcurso in concurso.Modalidades
                    join modalidade in _modalidadeRepository.GetQueryable().AsNoTracking()
                        on modalidadeConcurso.ModalidadeId equals modalidade.Id
                    where marca.Key == marcaKey &&
                    intake.Key == intakeKey &&
                    inscricao.Documentos.Any(x => x.Tipo == TipoDocumentoInscricao.Cpf && x.Valor == cpfSemFormatacao) &&
                    inscricao.Status.Any(s => s.Tipo == TipoStatusInscricao.TotalmenteConcluida) &&
                    formaEntrada.Key == FormaEntradaConstants.EnemKey && 
                    modalidade.Key == modalidadeKey
                    select concurso.Key;
                    
        return await query.AnyAsync();
    }
}