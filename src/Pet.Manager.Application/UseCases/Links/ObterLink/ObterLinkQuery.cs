using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Links;

namespace Anima.Inscricao.Application.UseCases.Links.ObterLink;

public class ObterLinkQuery : IQuery<LinkDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
