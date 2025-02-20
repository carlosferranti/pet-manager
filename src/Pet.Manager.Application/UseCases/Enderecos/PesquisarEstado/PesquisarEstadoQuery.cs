using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarEstado;

public class PesquisarEstadoQuery : IQuery<ResultadoPaginadoDto<EstadoDto>>
{
    public PesquisarEstadoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarEstadoFiltros(Guid? PaisKey);
}
