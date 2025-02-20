namespace Anima.Inscricao.Application.DTOs.OfertaConcursos;

public class CursoOfertadoDetalheDto
{
    public Guid OfertaKey { get; set; }

    public Guid ProdutoKey { get; set; }

    public Guid IntakeKey { get; set; }

    public string IntakeNome { get; set; } = string.Empty;

    public Guid ModalidadeKey { get; set; }

    public Guid MarcaKey { get; set; }

    public string ModalidadeNome { get; set; } = string.Empty;

    public string ModalidadeDescricao { get; set; } = string.Empty;

    public Guid TurnoKey { get; set; }

    public string TurnoNome { get; set; } = string.Empty;

    public Guid NivelKey { get; set; }

    public string NivelNome { get; set; } = string.Empty;

    public Guid TipoFormacaoKey { get; set; }

    public string TipoFormacaoNome { get; set; } = string.Empty;

    public Guid CampusKey { get; set; }

    public string CampusNome { get; set; } = string.Empty;

    public string CursoNome { get; set; } = string.Empty;

    public Guid LinkKey { get; set; }
}