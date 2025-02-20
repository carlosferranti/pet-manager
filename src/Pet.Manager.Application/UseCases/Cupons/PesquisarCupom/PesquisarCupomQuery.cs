using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cupons;

namespace Anima.Inscricao.Application.UseCases.Cupons.PesquisarCupom;

public class PesquisarCupomQuery : IQuery<ResultadoPaginadoDto<CupomDto>>
{
    public PesquisarCupomFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarCupomFiltros (string? Codigo, Guid? ConcursoKey, string? CodigoOrigem, string? PeriodoLetivo);
}
