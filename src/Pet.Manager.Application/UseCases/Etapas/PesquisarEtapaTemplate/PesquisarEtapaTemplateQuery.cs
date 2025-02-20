using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Etapas;

namespace Anima.Inscricao.Application.UseCases.Etapas.PesquisarEtapa;

public class PesquisarEtapaTemplateQuery : IQuery<ResultadoPaginadoDto<EtapaTemplateDto>>
{
    public PesquisarEtapaTemplateFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarEtapaTemplateFiltros(string Nome);
}