using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campi;

namespace Anima.Inscricao.Application.UseCases.Campi.PesquisarCampus;

public class PesquisarCampusQuery : IQuery<ResultadoPaginadoDto<CampusDto>>
{
    public PesquisarCampusFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarCampusFiltros (string Nome);
}
