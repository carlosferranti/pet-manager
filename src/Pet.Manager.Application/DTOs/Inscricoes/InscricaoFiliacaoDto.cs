namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoFiliacaoDto
{
    public string? Nome { get; set; }

    public int Tipo { get; set; }

    public string TipoDescricao { get; set; } = string.Empty;

    public Guid Key { get; set; }
}
