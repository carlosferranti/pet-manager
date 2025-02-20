using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Turnos;

namespace Anima.Inscricao.Application.UseCases.Turnos.PesquisarTurno;

public class PesquisarTurnoQuery : IQuery<ResultadoPaginadoDto<TurnoDto>>
{

    public PesquisarTurnoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarTurnoFiltros(string Nome);

}
