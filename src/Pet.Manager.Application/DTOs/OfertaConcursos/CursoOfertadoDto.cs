namespace Anima.Inscricao.Application.DTOs.OfertaConcursos;

public class CursoOfertadoDto
{
    public string CursoNome { get; set; } = string.Empty;

    public Guid NivelCursoKey { get; set; }

    public string NivelCursoNome { get; set; } = string.Empty;

    public Guid IntakeKey { get; set; }

    public string IntakeNome { get; set; } = string.Empty;

    public Guid MarcaKey { get; set; }

    public string MarcaNome { get; set; } = string.Empty;

    public Guid LinkKey { get; set; }
}