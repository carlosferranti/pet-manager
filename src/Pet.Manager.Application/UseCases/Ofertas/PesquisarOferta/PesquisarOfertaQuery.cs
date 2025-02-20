using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Ofertas;

namespace Anima.Inscricao.Application.UseCases.Ofertas.PesquisarOferta;

public class PesquisarOfertaQuery : IQuery<ResultadoPaginadoDto<OfertaDto>>
{
    public PesquisarOfertaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarOfertaFiltros(Guid? ProdutoKey, Guid? IntakeKey);
}
