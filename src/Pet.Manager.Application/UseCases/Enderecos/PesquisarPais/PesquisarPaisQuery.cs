using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarPais;

public class PesquisarPaisQuery : IQuery<ResultadoPaginadoDto<PaisDto>>
{
    public PesquisarPaisFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarPaisFiltros(string? Nome, string? Sigla);
}