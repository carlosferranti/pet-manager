using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Links.Entities;

public record LinkId : EntityId
{
    public LinkId(int linkId)
        : base(linkId) { }

    public static implicit operator LinkId(int id)
    {
        return new LinkId(id);
    }
    public static implicit operator int(LinkId linkId)
    {
        return linkId.Id;
    }
}