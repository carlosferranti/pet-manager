using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cofiguracao;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.PesquisarConfiguracao;

public class PesquisarConfiguracaoQuery : IQuery<ResultadoPaginadoDto<ConfiguracaoDto>>
{

    public PesquisarConfiguracaoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarConfiguracaoFiltros(string? ChaveGenerica, string? Valor);
}
