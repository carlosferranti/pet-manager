using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Cursos.PesquisarCurso;

public class PesquisarCursoQueryHandler : IQueryHandler<PesquisarCursoQuery, ResultadoPaginadoDto<CursoDto>>
{
    private readonly ICursoRepository _cursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;

    public PesquisarCursoQueryHandler(
        ICursoRepository cursoRepository,
        IModalidadeRepository modalidadeRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        INivelCursoRepository nivelCursoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IInstituicaoRepository instituicaoRepository)
    {
        _cursoRepository = cursoRepository;
        _modalidadeRepository = modalidadeRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _instituicaoRepository = instituicaoRepository;
    }

    public async Task<ResultadoPaginadoDto<CursoDto>> Handle(PesquisarCursoQuery request, CancellationToken cancellationToken)
    {
        var query = from curso in _cursoRepository.GetQueryable()
                    join modalidade in _modalidadeRepository.GetQueryable()
                        on curso.ModalidadeId equals modalidade.Id
                    join tipoFormacao in _tipoFormacaoRepository.GetQueryable()
                        on curso.TipoFormacaoId equals tipoFormacao.Id
                    join nivelCurso in _nivelCursoRepository.GetQueryable()
                        on curso.NivelCursoId equals nivelCurso.Id
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on curso.IntegracaoCurso!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    join instituicao in _instituicaoRepository.GetQueryable()
                        on curso.InstituicaoId equals instituicao.Id
                    select new CursoDto
                    {
                        Key = curso.Key,
                        Nome = curso.Nome,
                        NomeComercial = curso.NomeComercial,
                        ModalidadeKey = modalidade.Key,
                        TipoFormacaoKey = tipoFormacao.Key,
                        NivelFormacaoKey = nivelCurso.Key,
                        InstituicaoKey = instituicao.Key,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto
                        {
                            CodigoOrigem = curso.IntegracaoCurso!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };

        query = AplicarFiltros(request, query);

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<CursoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }

    private static IQueryable<CursoDto> AplicarFiltros(PesquisarCursoQuery request, IQueryable<CursoDto> query)
    {
        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        if (request.Filtros?.ModalidadeKey != null)
        {
            query = query.Where(o => o.ModalidadeKey == request.Filtros!.ModalidadeKey.Value);
        }

        if (request.Filtros?.TipoFormacaoKey != null)
        {
            query = query.Where(o => o.TipoFormacaoKey == request.Filtros!.TipoFormacaoKey.Value);
        }

        if (request.Filtros?.NivelCursoKey != null)
        {
            query = query.Where(o => o.NivelFormacaoKey == request.Filtros!.NivelCursoKey.Value);
        }

        if (request.Filtros?.InstituicaoKey != null)
        {
            query = query.Where(o => o.InstituicaoKey == request.Filtros!.InstituicaoKey.Value);
        }

        return query;
    }
}
