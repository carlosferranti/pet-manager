using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;

public class RemoverOfertaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
