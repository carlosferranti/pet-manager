using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Fichas;

namespace Anima.Inscricao.Application.UseCases.Fichas.PesquisarFicha;

public class PesquisarFichaQuery : IQuery<ResultadoPaginadoDto<FichaDto>>
{
    public PesquisarFichaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarFichaFiltros(string Nome);
}
