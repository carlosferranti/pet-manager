namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoOpcaoAcessoDto
{
    public Guid Key { get; set; }

    public int Tipo { get; set; }

    public string Nome { get; set; } = string.Empty;

    public decimal? Percentual { get; set; }
}