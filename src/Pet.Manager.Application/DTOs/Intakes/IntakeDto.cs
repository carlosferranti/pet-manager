using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Intakes;

public class IntakeDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public DateTime VigenciaInicio { get; set; }

    public DateTime VigenciaTermino { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
