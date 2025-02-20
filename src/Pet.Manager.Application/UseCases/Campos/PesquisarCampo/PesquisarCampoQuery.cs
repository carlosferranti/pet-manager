using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campos;

namespace Anima.Inscricao.Application.UseCases.Campos.PesquisarCampo;

public class PesquisarCampoQuery : IQuery<ResultadoPaginadoDto<CampoDto>>
{
    public PesquisarCampoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarCampoFiltros(string Nome);
}