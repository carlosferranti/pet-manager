using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Intakes;

namespace Anima.Inscricao.Application.UseCases.Intakes.PesquisarIntake;

public class PesquisarIntakeQuery : IQuery<ResultadoPaginadoDto<IntakeDto>>
{
    public PesquisarIntakeFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarIntakeFiltros(string Nome);
}
