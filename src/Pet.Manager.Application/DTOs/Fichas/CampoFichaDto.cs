namespace Anima.Inscricao.Application.DTOs.Fichas;

public class CampoFichaDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public bool ObrigatorioNaFicha { get; set; }

    public bool ObrigatorioNoComplemento { get; set; }
}