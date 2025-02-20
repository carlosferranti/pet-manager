using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;

public class RemoverModalidadeCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
