using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campos;
using Anima.Inscricao.Domain.Campos;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Campos.PesquisarCampo;

public class PesquisarCampoQueryHandler : IQueryHandler<PesquisarCampoQuery, ResultadoPaginadoDto<CampoDto>>
{
    private readonly ICampoRepository _campoRepository;

    public PesquisarCampoQueryHandler(ICampoRepository campoRepository)
    {
        _campoRepository = campoRepository;
    }

    public async Task<ResultadoPaginadoDto<CampoDto>> Handle(PesquisarCampoQuery request, CancellationToken cancellationToken)
    {
        var query = _campoRepository.GetQueryable();

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
            .Select(o => new CampoDto()
            {
                Key = o.Key,
                Nome = o.Nome,
            });

        return new ResultadoPaginadoDto<CampoDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}
