using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.NiveisCurso;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.NiveisCurso;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.PesquisarNivelCurso;

public class PesquisarNivelCursoQueryHandler : IQueryHandler<PesquisarNivelCursoQuery, ResultadoPaginadoDto<NivelCursoDto>>
{
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarNivelCursoQueryHandler(INivelCursoRepository nivelCursoRepository, IIntegracaoSistemaRepository integracaoSistemaRepository)
    {
        _nivelCursoRepository = nivelCursoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
    }

    public async Task<ResultadoPaginadoDto<NivelCursoDto>> Handle(PesquisarNivelCursoQuery request, CancellationToken cancellationToken)
    {
        var query = from nivel in _nivelCursoRepository.GetQueryable()
                    join integracao in _integracaoSistemaRepository.GetQueryable()
                        on nivel.IntegracaoNivelCurso!.IntegracaoSistemaId equals integracao.Id into integracaoJoin
                    from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                    select new NivelCursoDto()
                    {
                        Key = nivel.Key,
                        Nome = nivel.Nome,
                        Integracao = integracaoSistema != null ? new SistemaIntegracaoDto()
                        {
                            CodigoOrigem = nivel.IntegracaoNivelCurso!.CodigoOrigem,
                            NomeSistema = integracaoSistema.Nome
                        } : null
                    };

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .OrderBy(o => o.Nome)
            .ThenBy(o => o.Key)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros);

        return new ResultadoPaginadoDto<NivelCursoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
