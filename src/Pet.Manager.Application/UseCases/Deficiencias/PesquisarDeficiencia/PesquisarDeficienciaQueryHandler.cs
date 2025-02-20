using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;

public class PesquisarDeficienciaQueryHandler : IQueryHandler<PesquisarDeficienciaQuery, ResultadoPaginadoDto<DeficienciaDto>>
{
    private readonly IDeficienciaRepository _deficienciaRepository;

    public PesquisarDeficienciaQueryHandler(IDeficienciaRepository deficienciaRepository)
    {
        _deficienciaRepository = deficienciaRepository;
    }

    public async Task<ResultadoPaginadoDto<DeficienciaDto>> Handle(PesquisarDeficienciaQuery request, CancellationToken cancellationToken)
    {
        var query = _deficienciaRepository.GetQueryable();

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
            .Select(o => new DeficienciaDto()
            {
                Key = o.Key,
                Nome = o.Nome,
                OrdemExibicao = o.OrdemExibicao,
            });

        return new ResultadoPaginadoDto<DeficienciaDto>(
            await queryResult.ToListAsync(cancellationToken),
            request.Paginacao.NumeroPagina,
            request.Paginacao.QuantidadeRegistros,
            totalRegistros
        );
    }
}