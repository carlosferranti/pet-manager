using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Turnos;

public class TurnoDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
