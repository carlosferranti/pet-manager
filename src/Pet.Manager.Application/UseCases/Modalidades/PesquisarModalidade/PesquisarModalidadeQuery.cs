using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Modalidades;

namespace Anima.Inscricao.Application.UseCases.Modalidades.PesquisarModalidade;

public class PesquisarModalidadeQuery : IQuery<ResultadoPaginadoDto<ModalidadeDto>>
{
    public PesquisarModalidadeFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarModalidadeFiltros(string Nome);
}