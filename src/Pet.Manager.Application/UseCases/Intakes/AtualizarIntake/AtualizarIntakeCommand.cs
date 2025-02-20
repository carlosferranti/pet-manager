using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;

public class AtualizarIntakeCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public DateTime VigenciaInicio { get; set; }

    public DateTime VigenciaTermino { get; set; }
}
