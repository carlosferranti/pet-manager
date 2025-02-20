using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.CursosExternos;

namespace Anima.Inscricao.Application.UseCases.CursosExternos.PesquisarCursoExterno;

public class PesquisarCursoExternoQuery : IQuery<IEnumerable<CursoExternoDto>>
{
    public PesquisarCursoExternoFiltro? Filtros { get; set; }

    public record PesquisarCursoExternoFiltro(string Nome);
}
