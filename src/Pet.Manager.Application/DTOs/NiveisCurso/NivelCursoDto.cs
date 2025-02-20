using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.NiveisCurso;

public class NivelCursoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
