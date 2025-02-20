using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;
using Anima.Inscricao.Domain.Enderecos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarPais;

public class PesquisarPaisQueryHandler : IQueryHandler<PesquisarPaisQuery, ResultadoPaginadoDto<PaisDto>>
{
    private readonly IPaisRepository _paisRepository;

    public PesquisarPaisQueryHandler(IPaisRepository paisRepository)
    {
        _paisRepository = paisRepository;
    }

    public async Task<ResultadoPaginadoDto<PaisDto>> Handle(PesquisarPaisQuery request, CancellationToken cancellationToken)
    {
        var query = _paisRepository.GetQueryable();

        if (!string.IsNullOrEmpty(request.Filtros?.Sigla))
        {
            query = query.Where(o => o.Sigla.ToUpper().Contains(request.Filtros.Sigla.ToUpper()));
        }

        if (!string.IsNullOrEmpty(request.Filtros?.Nome))
        {
            query = query.Where(o => o.Nome.ToUpper().Contains(request.Filtros.Nome.ToUpper()));
        }

        int totalRegistros = await query.CountAsync();

        var queryResult = query
            .Where(m => m.Status.Ativo)
            .OrderBy(o => o.Nome)
            .Skip(request.Paginacao.QuantidadeRegistros * (request.Paginacao.NumeroPagina - 1))
            .Take(request.Paginacao.QuantidadeRegistros)
            .Select(o => new PaisDto()
            {
                Key = o.Key,
                Nome = o.Nome,
                Sigla = o.Sigla,
                SiglaAbreviada = o.SiglaAbreviada,
                Tipo = o.Tipo,
            });

        return new ResultadoPaginadoDto<PaisDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
