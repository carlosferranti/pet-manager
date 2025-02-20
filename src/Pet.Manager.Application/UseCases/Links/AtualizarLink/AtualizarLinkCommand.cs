using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.UseCases.Links.AtualizarLink;

public class AtualizarLinkCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public List<EntityKeyDto>? FormasEntrada { get; set; }
}
