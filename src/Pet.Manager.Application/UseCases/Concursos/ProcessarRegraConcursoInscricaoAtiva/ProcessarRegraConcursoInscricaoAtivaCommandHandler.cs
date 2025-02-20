using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoReopcao;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Utils;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation.TestHelper;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;

public class ProcessarRegraConcursoInscricaoAtivaCommandHandler : ICommandHandler<ProcessarRegraConcursoInscricaoAtivaCommand, List<ConcursosPorOfertaDto>>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ICandidatoRepository _candidatoRepository;

    private readonly ILogger<ProcessarRegraConcursoInscricaoAtivaCommandHandler> _logger;

    public ProcessarRegraConcursoInscricaoAtivaCommandHandler(
        IInscricaoRepository inscricaoRepository,
        IConcursoRepository concursoRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IIntakeRepository intakeRepository,
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IFormaEntradaRepository formaEntradaRepository,
        ILogger<ProcessarRegraConcursoInscricaoAtivaCommandHandler> logger,
        ICandidatoRepository candidatoRepository)
    {
        _inscricaoRepository = inscricaoRepository;
        _concursoRepository = concursoRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _intakeRepository = intakeRepository;
        _marcaRepository = marcaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _logger = logger;
        _candidatoRepository = candidatoRepository;

    }

    public async Task<List<ConcursosPorOfertaDto>> Handle(ProcessarRegraConcursoInscricaoAtivaCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var inscricoesAnteriores = await ObterInscricoesConcluidasAsync(request.MarcaKey, request.IntakeKey, CpfFormater.RemoverFormatacao(request.Cpf));

            if (inscricoesAnteriores != null && inscricoesAnteriores.Any())
            {
                foreach (var inscricao in inscricoesAnteriores)
                {
                    var codigoInscricao = inscricao.Integracoes?.FirstOrDefault(x => x.NomeSistema == IntegracaoSistemaConstants.Vestib)?.CodigoOrigem;
                    var formaEntradaSelecionadaKey = inscricao.Oferta?.FormasEntrada?.FirstOrDefault(fe => fe.TipoSelecao == TipoSelecaoFormaEntrada.Manual)?.FormaEntradaKey;
                    var codigoConcurso = inscricao.Oferta!.Concurso!.Integracao!.CodigoOrigem;

                    if (formaEntradaSelecionadaKey == FormaEntradaConstants.EntradaSimplificadaKey && 
                    codigoInscricao is not null &&
                    await _candidatoRepository.VerificarReprovacaoCandidato(codigoConcurso, codigoInscricao))
                       continue;

                    if (codigoInscricao is not null && await _candidatoRepository.VerificarInscricaoCancelada(codigoConcurso, codigoInscricao))
                        continue;

                    request.FormasEntrada.RemoveAll(c => c.Concursos.Exists(cc => cc.ConcursoKey == inscricao.Oferta.Concurso.Key));
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao processar regra de concurso único por cpf/modalidade. {@Request}", request);
        }

        return request.FormasEntrada;
    }

    public virtual Task<List<InscricaoDto>> ObterInscricoesConcluidasAsync(Guid marcaKey, Guid intakeKey, string cpf)
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
                    from integracaoConcurso in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
                    .Where(i => i.Id == concurso.IntegracaoConcurso!.IntegracaoSistemaId).DefaultIfEmpty()
                    where marca.Key == marcaKey &&
                    intake.Key == intakeKey &&
                    inscricao.Documentos.Any(x => x.Tipo == TipoDocumentoInscricao.Cpf && x.Valor == cpfSemFormatacao) &&
                    inscricao.Status.Any(s => s.Tipo == TipoStatusInscricao.TotalmenteConcluida)
                    select new InscricaoDto
                    {
                        Key = inscricao.Key,
                        Oferta = new()
                        {
                            FormasEntrada = (from inscricaoFormaEntrada in inscricao.FormasEntrada
                                             join formaEntrada in _formaEntradaRepository.GetQueryable()
                                                on inscricaoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                                             where inscricaoFormaEntrada.Atual
                                             select new InscricaoFormaEntradaDto()
                                             {
                                                 FormaEntradaKey = formaEntrada.Key,
                                                 FormaEntradaNome = formaEntrada.Nome,
                                                 TipoSelecao = inscricaoFormaEntrada.CodigoTipoSelecao,
                                             }).ToList(),
                            Concurso = new()
                            {
                                Key = concurso.Key,
                                Nome = concurso.Nome,
                                Integracao = concurso.IntegracaoConcurso != null ? new SistemaIntegracaoDto()
                                {
                                    CodigoOrigem = concurso.IntegracaoConcurso!.CodigoOrigem,
                                    NomeSistema = integracaoConcurso.Nome,
                                } : null,
                            },
                        },
                        Integracoes = (from integracaoInscricao in inscricao.IntegracoesInscricao
                                       join sistema in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
                                       on integracaoInscricao.IntegracaoSistemaId equals sistema.Id
                                       select new SistemaIntegracaoDto()
                                       {
                                           CodigoOrigem = integracaoInscricao.CodigoOrigem,
                                           NomeSistema = sistema.Nome,
                                       })
                    };

        return query.ToListAsync();

    }
}