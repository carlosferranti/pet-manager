using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Domain.Marcas;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Marcas.PesquisarMarca;

public class PesquisarMarcaQueryHandler : IQueryHandler<PesquisarMarcaQuery, ResultadoPaginadoDto<MarcaDto>>
{
    private readonly IMarcaRepository _marcaRepository;

    public PesquisarMarcaQueryHandler(
        IMarcaRepository marcaRepository)
    {
        _marcaRepository = marcaRepository;
    }

    public async Task<ResultadoPaginadoDto<MarcaDto>> Handle(PesquisarMarcaQuery request, CancellationToken cancellationToken)
    {
        var query = _marcaRepository.GetQueryable();

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
            .Select(m => new MarcaDto()
            {
                Key = m.Key,
                Nome = m.Nome,
                Sigla = m.Sigla,
            });

        return new ResultadoPaginadoDto<MarcaDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
