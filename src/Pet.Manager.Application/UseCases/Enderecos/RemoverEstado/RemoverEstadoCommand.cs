using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverEstado;

public class RemoverEstadoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}