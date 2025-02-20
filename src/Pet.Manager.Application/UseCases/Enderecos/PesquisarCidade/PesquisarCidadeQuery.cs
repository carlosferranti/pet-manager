using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.PesquisarCidade;

public class PesquisarCidadeQuery : IQuery<ResultadoPaginadoDto<CidadeDto>>
{
    public PesquisarCidadeFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarCidadeFiltros(Guid? EstadoKey);
}