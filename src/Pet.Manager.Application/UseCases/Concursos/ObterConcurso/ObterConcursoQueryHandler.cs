using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.ModalidadesAvaliacao;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Concursos.ObterConcurso;

public class ObterConcursoQueryHandler : IQueryHandler<ObterConcursoQuery, ConcursoDto>
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public ObterConcursoQueryHandler(
        IConcursoRepository concursoRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IModalidadeRepository modalidadeRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository)
    {
        _concursoRepository = concursoRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _modalidadeRepository = modalidadeRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;
    }

    public async Task<ConcursoDto> Handle(ObterConcursoQuery request, CancellationToken cancellationToken)
    {
        var queryFormaEntrada = from formaEntrada in _formaEntradaRepository.GetQueryable()
                                select new
                                {
                                    Id = formaEntrada.Id,
                                    Key = formaEntrada.Key,
                                    Nome = formaEntrada.Nome,
                                };

        var query = from concurso in _concursoRepository.GetQueryable()
                    from tipoFormacao in _tipoFormacaoRepository.GetQueryable()
                    from modalidade in _modalidadeRepository.GetQueryable()
                    join modalidadeAvaliacao in _modalidadeAvaliacaoRepository.GetQueryable().DefaultIfEmpty()
                        on concurso.ModalidadeAvaliacaoId equals modalidadeAvaliacao.Id into modalidadeAvaliacaoGroup
                    from modalidadeAvaliacao in modalidadeAvaliacaoGroup.DefaultIfEmpty()
                    where concurso.Key == request.Key &&
                    concurso.TiposFormacao.Any(x => x.TipoFormacaoId == tipoFormacao.Id) &&
                    concurso.Modalidades.Any(x => x.ModalidadeId == modalidade.Id)
                    select new ConcursoDto()
                    {
                        Key = concurso.Key,
                        Nome = concurso.Nome,
                        PeriodoLetivo = concurso.PeriodoLetivo,
                        InicioInscricao = concurso.VigenciaInscricao.Inicio,
                        TerminoInscricao = concurso.VigenciaInscricao.Termino,
                        InicioProva = concurso.InicioProva,
                        TerminoProva = concurso.TerminoProva,
                        DivulgacaoResultado = concurso.DivulgacaoResultado,
                        FormasEntrada = queryFormaEntrada
                            .Where(f => concurso.FormasEntrada.Any(x => x.FormaEntradaId == f.Id))
                            .Select(f => new FormaEntradaDto()
                            {
                                Key = f.Key,
                                Nome = f.Nome,
                            }).ToList(),
                        TipoFormacao = new TipoFormacaoDto()
                        {
                            Key = tipoFormacao.Key,
                            Nome = tipoFormacao.Nome,
                        },
                        Modalidade = new ModalidadeDto()
                        {
                            Key = modalidade.Key,
                            Nome = modalidade.Nome,
                        },
                        Parametros = concurso.ConcursoParametros != null ? new ConcursoParametrosDto()
                        {
                            SolicitaAnoInscricaoEnem = concurso.ConcursoParametros.SolicitaAnoInscricaoEnem,
                            ExigeAceiteDeferimento = concurso.ConcursoParametros.ExigeAceiteDeferimento,
                            RecebeDocumentoConclusaoEnsinoSuperior = concurso.ConcursoParametros.RecebeDocumentoConclusaoEnsinoSuperior,
                        } : null,
                        ModalidadeAvaliacao = modalidadeAvaliacao != null ? new ModalidadeAvaliacaoDto()
                        {
                            Key = modalidadeAvaliacao.Key,
                            Nome = modalidadeAvaliacao.Nome,
                        } : null,
                    };

        return await query.SingleAsync();
    }
}