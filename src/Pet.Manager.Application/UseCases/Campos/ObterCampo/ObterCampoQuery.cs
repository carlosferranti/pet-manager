using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campos;

namespace Anima.Inscricao.Application.UseCases.Campos.ObterCampo;

public class ObterCampoQuery : IQuery<CampoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}