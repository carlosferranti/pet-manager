using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Campos.RemoverCampo;

public class RemoverCampoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
