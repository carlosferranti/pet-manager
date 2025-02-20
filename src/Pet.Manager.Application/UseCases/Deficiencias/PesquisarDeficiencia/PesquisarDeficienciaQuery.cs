using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Deficiencias;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.PesquisarDeficiencia;

public class PesquisarDeficienciaQuery : IQuery<ResultadoPaginadoDto<DeficienciaDto>>
{
    public PesquisarDeficienciaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarDeficienciaFiltros(string Nome);
}
