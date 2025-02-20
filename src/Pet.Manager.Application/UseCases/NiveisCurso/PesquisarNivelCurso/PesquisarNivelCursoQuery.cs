using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.NiveisCurso;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.PesquisarNivelCurso;

public class PesquisarNivelCursoQuery : IQuery<ResultadoPaginadoDto<NivelCursoDto>>
{
    public PesquisarNivelCursoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarNivelCursoFiltros (string? Nome);
}
