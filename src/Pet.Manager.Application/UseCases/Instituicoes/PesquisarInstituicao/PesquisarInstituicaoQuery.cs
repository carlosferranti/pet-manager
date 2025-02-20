using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Instituicao;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarInstituicao;

public class PesquisarInstituicaoQuery : IQuery<ResultadoPaginadoDto<InstituicaoDto>>
{
    public PesquisarInstituicaoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarInstituicaoFiltros (string Nome, Guid? MarcaKey);
}
