namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoInfosPessoaisDto
{
    public string Nome { get; set; } = string.Empty;

    public DateOnly? DataNascimento { get; set; }

    public int? Sexo { get; set; }

    public bool? NecessidadeEspecial { get; set; }

    public string? NomeSocial { get; set; }
}