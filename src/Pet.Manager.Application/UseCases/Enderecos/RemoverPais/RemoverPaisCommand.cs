using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverPais;

public class RemoverPaisCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}