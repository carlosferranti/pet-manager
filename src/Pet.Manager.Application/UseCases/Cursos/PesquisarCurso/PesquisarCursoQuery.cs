using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cursos;

namespace Anima.Inscricao.Application.UseCases.Cursos.PesquisarCurso;

public class PesquisarCursoQuery : IQuery<ResultadoPaginadoDto<CursoDto>>
{
    public PesquisarCursoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarCursoFiltros(string Nome, Guid? ModalidadeKey, Guid? TipoFormacaoKey, Guid? NivelCursoKey, Guid? InstituicaoKey);
}
