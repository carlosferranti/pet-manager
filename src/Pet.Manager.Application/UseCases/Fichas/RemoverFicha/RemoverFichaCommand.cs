using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Fichas.RemoverFicha;

public class RemoverFichaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
