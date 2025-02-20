using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.CursosExternos;

public class CursoExternoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public IEnumerable<SistemaIntegracaoDto>? Integracoes { get; set; }
}
