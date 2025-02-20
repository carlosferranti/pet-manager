using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Marcas.RemoverMarca;

public class RemoverMarcaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
