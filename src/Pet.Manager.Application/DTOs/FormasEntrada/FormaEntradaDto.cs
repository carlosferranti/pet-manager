using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.FormasEntrada;

public class FormaEntradaDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public int OrdemExibicao { get; set; }

    public List<SistemaIntegracaoDto>? Integracao { get; set; }
}
