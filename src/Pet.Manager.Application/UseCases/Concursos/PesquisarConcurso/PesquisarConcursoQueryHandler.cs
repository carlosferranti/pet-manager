using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.ModalidadesAvaliacao;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.DTOs.TiposFormacao;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcurso;

public class PesquisarConcursoQueryHandler : IQueryHandler<PesquisarConcursoQuery, ResultadoPaginadoDto<ConcursoDto>>
{
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public PesquisarConcursoQueryHandler(
        IConcursoRepository concursoRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IModalidadeRepository modalidadeRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository)
    {
        _concursoRepository = concursoRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _modalidadeRepository = modalidadeRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;
    }

    public async Task<ResultadoPaginadoDto<ConcursoDto>> Handle(PesquisarConcursoQuery request, CancellationToken cancellationToken)
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
                    from integracao in _integracaoSistemaRepository.GetQueryable()
                        .Where(i => i.Id == concurso.IntegracaoConcurso!.IntegracaoSistemaId).DefaultIfEmpty()
                    join modalidadeAvaliacao in _modalidadeAvaliacaoRepository.GetQueryable().DefaultIfEmpty()
                        on concurso.ModalidadeAvaliacaoId equals modalidadeAvaliacao.Id into modalidadeAvaliacaoGroup
                    from modalidadeAvaliacao in modalidadeAvaliacaoGroup.DefaultIfEmpty()
                    where concurso.Status.Ativo &&
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
                        Integracao = concurso.IntegracaoConcurso != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = concurso.IntegracaoConcurso!.CodigoOrigem,
                            NomeSistema = integracao.Nome,
                        } : null,
                        IntegracaoFormaProva = (from concursoIntegracaoFormaProva in concurso.IntegracoesFormaProva
                                                join sistema in _integracaoSistemaRepository.GetQueryable()
                                                    on concursoIntegracaoFormaProva.IntegracaoSistemaId equals sistema.Id into sistemas
                                                from integracoes in sistemas.DefaultIfEmpty()
                                                select new SistemaIntegracaoDto()
                                                {
                                                    CodigoOrigem = concursoIntegracaoFormaProva.CodigoOrigem,
                                                    NomeSistema = integracoes.Nome,
                                                }).ToList(),
                        ModalidadeAvaliacao = modalidadeAvaliacao != null ? new ModalidadeAvaliacaoDto()
                        {
                            Key = modalidadeAvaliacao.Key,
                            Nome = modalidadeAvaliacao.Nome,
                        } : null,
                    };

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        if(!string.IsNullOrEmpty(request.Filtros?.CodigoOrigem))
        {
            query = query.Where(o => o.Integracao!.CodigoOrigem == request.Filtros.CodigoOrigem);
        }

        if (!string.IsNullOrEmpty(request.Filtros?.PeriodoLetivo))
        {
            query = query.Where(o => o.PeriodoLetivo == request.Filtros.PeriodoLetivo);
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<ConcursoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}