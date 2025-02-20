using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Concursos;

public class ConcursoEventoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
