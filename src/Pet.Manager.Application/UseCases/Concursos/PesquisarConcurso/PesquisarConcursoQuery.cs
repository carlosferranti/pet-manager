using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Concursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcurso;

public class PesquisarConcursoQuery : IQuery<ResultadoPaginadoDto<ConcursoDto>>
{
    public PesquisarConcursoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarConcursoFiltros(string? Nome, string? CodigoOrigem, string? PeriodoLetivo);
}
