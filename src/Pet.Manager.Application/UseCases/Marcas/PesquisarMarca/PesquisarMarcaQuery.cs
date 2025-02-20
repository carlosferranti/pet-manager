using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Marcas;

namespace Anima.Inscricao.Application.UseCases.Marcas.PesquisarMarca;

public class PesquisarMarcaQuery : IQuery<ResultadoPaginadoDto<MarcaDto>>
{
    public PesquisarMarcaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarMarcaFiltros(string Nome);
}
