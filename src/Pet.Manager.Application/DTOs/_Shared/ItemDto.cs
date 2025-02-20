using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs._Shared;

public class ItemDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SistemaIntegracaoDto? Integracao { get; set; }
}