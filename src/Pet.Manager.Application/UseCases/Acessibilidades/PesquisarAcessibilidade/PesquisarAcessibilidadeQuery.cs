using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Acessibilidades;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.PesquisarAcessibilidade;

public class PesquisarAcessibilidadeQuery : IQuery<ResultadoPaginadoDto<AcessibilidadeDto>>
{
    public PesquisarAcessibilidadeFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarAcessibilidadeFiltros (string Nome);
}
