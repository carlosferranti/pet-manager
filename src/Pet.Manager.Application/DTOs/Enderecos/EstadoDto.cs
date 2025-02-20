namespace Anima.Inscricao.Application.DTOs.Enderecos;

public class EstadoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public Guid PaisKey { get; set; }
}