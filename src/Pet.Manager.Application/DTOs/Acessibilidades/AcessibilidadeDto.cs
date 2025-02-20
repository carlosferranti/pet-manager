using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Acessibilidades;

public class AcessibilidadeDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SistemaIntegracaoDto? Integracao { get; set; }
}
