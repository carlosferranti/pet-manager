using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Deficiencias;

public class DeficienciaDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public int? OrdemExibicao { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}