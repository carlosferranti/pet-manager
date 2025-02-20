using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.FormasEntrada;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.PesquisarFormaEntrada;

public class PesquisarFormaEntradaQuery : IQuery<ResultadoPaginadoDto<FormaEntradaDto>>
{
    public PesquisarFormaEntradaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarFormaEntradaFiltros(string Nome);
}