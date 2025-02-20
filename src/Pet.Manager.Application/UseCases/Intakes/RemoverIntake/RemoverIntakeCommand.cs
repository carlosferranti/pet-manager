using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Intakes.RemoverIntake;

public class RemoverIntakeCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}