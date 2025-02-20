namespace Anima.Inscricao.Application.DTOs.Fichas;

public class FichaDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public bool Padrao { get; set; }

    public List<EtapaFichaDto>? Etapas { get; set; } = new();

    public List<CampoFichaDto>? Campos { get; set; } = new();
}
