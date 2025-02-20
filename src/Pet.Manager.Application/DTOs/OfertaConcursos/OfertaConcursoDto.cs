using Anima.Inscricao.Domain.OfertaConcursos.Enums;

namespace Anima.Inscricao.Application.DTOs.OfertaConcursos;

public class OfertaConcursoDto
{
    public Guid Key { get; set; }

    public Guid ConcursoKey { get; set; }

    public Guid OfertaKey { get; set; }

    public List<TipoOpcaoAcesso>? OpcaoAcesso { get; set; }
}
