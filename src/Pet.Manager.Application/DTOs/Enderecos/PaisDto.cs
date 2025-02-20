namespace Anima.Inscricao.Application.DTOs.Enderecos;

public class PaisDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public string SiglaAbreviada { get; set; } = string.Empty;

    public string? Tipo { get; set; }
}
