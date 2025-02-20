namespace Anima.Inscricao.Application.Config;

public class CacheConfig
{
    public string? Tipo { get; set; }

    public string? Chave { get; set; }

    public int? TtlEmSegundos { get; set; }
}