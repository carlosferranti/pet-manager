using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.PesquisarAcessibilidade;

public class PesquisarAcessibilidadeQueryHandler : IQueryHandler<PesquisarAcessibilidadeQuery, ResultadoPaginadoDto<AcessibilidadeDto>>
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public PesquisarAcessibilidadeQueryHandler(IAcessibilidadeRepository acessibilidadeRepository)
    {
        _acessibilidadeRepository = acessibilidadeRepository;
    }

    public async Task<ResultadoPaginadoDto<AcessibilidadeDto>> Handle(PesquisarAcessibilidadeQuery request, CancellationToken cancellationToken)
    {
        var query = _acessibilidadeRepository.GetQueryable();

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.Trim().ToUpper().Contains(request.Filtros.Nome.Trim().ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .Where(m => m.Status.Ativo)
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros)
            .Select(o => new AcessibilidadeDto()
            {
                Key = o.Key,
                Nome = o.Nome,
            });

        return new ResultadoPaginadoDto<AcessibilidadeDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
