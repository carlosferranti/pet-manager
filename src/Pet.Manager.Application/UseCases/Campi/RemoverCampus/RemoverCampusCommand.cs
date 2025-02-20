using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Campi.RemoverCampus;

public class RemoverCampusCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
