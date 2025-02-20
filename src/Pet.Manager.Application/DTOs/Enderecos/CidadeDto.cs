namespace Anima.Inscricao.Application.DTOs.Enderecos;

public class CidadeDto
{
    public Guid Key { get; set; }
    public string Nome { get; set; } = string.Empty;
    public Guid EstadoKey { get; set; }
    public int? CodigoMunicipio { get; set; }
    public int? Ddd { get; set; }
}