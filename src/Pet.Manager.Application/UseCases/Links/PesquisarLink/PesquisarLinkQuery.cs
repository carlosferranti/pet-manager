using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Links;

namespace Anima.Inscricao.Application.UseCases.Links.PesquisarLink;

public class PesquisarLinkQuery : IQuery<ResultadoPaginadoDto<LinkDto>>
{
    public PesquisarLinkFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarLinkFiltros(Guid? FormaEntradaKey);
}