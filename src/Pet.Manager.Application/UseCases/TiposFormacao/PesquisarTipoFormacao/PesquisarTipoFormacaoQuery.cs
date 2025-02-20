using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.PesquisarTipoFormacao;

public class PesquisarTipoFormacaoQuery : IQuery<ResultadoPaginadoDto<TipoFormacaoDto>>
{
    public PesquisarTipoFormacaoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarTipoFormacaoFiltros(string Nome);
}
