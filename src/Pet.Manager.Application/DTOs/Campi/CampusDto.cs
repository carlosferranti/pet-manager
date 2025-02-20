using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Campi;

public class CampusDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string? NomeComercial { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
