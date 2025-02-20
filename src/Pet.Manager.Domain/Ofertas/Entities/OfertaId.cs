using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Entities;

public record OfertaId : EntityId
{
    public OfertaId(int ofertaId)
        : base(ofertaId) { }

    public static implicit operator OfertaId(int id)
    {
        return new OfertaId(id);
    }

    public static implicit operator int(OfertaId ofertaId)
    {
        return ofertaId.Id;
    }
}