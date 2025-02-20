using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Turnos.RemoverTurno;

public class RemoverTurnoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
