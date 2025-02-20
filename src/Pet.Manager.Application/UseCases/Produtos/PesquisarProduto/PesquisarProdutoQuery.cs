using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Produtos;

namespace Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;

public class PesquisarProdutoQuery : IQuery<ResultadoPaginadoDto<ProdutoDto>>
{
    public PesquisarProdutoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarProdutoFiltros(
        Guid? InstituicaoKey,
        Guid? CampusKey,
        Guid? CursoKey,
        Guid? TurnoKey,
        string? Sku);
}