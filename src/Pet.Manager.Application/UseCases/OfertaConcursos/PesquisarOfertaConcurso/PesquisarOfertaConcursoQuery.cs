using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarOfertaConcurso;

public class PesquisarOfertaConcursoQuery : IQuery<ResultadoPaginadoDto<OfertaConcursoDto>>
{
    public PesquisarOfertaConcursoFiltros? Filtros { get; set; }

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarOfertaConcursoFiltros(Guid? OfertaKey, Guid? ConcursoKey);
}

