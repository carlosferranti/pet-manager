using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;

public class PesquisarCursosOfertadosQuery : IQuery<List<CursoOfertadoDto>>
{
    public PesquisarCursoOfertadoFiltros? Filtros { get; set; }

    public record PesquisarCursoOfertadoFiltros 
    {
        public Guid? MarcaKey { get; set; }

        public Guid? LinkKey { get; set; } = LinkConstants.LinkPadrao;
    }
}