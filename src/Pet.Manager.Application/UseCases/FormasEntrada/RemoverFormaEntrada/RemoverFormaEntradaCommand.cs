using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.RemoverFormaEntrada;

public class RemoverFormaEntradaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
