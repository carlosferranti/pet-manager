using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Domain.Escolas.Enums;

namespace Anima.Inscricao.Application.UseCases.Escolas.PesquisarEscola;

public class PesquisarEscolaQuery : IQuery<ResultadoPaginadoDto<EscolaDto>>
{
    public PesquisarEscolaFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarEscolaFiltros (Guid? CidadeKey, TipoCategoriaEscola? TipoCategoria);
}
