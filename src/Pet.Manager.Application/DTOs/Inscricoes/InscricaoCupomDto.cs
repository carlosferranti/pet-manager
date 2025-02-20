namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoCupomDto
{
    public Guid? Key { get; set; }

    public string? Codigo { get; set; }

    public int Tipo { get; set; }

    public string TipoDescricao { get; set; } = string.Empty;

    public float? Valor { get; set; }
}
