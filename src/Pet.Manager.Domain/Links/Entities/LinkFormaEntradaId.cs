using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Links.Entities;

public record LinkFormaEntradaId : EntityId
{
    public LinkFormaEntradaId(int linkFormaEntradaId)
        : base(linkFormaEntradaId) { }

    public static implicit operator LinkFormaEntradaId(int id)
    {
        return new LinkFormaEntradaId(id);
    }

    public static implicit operator int(LinkFormaEntradaId linkFormaEntradaId)
    {
        return linkFormaEntradaId.Id;
    }
}