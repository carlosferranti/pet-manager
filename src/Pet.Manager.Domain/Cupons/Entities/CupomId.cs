using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Cupons.Entities;

public record CupomId : EntityId
{
    public CupomId(int cupomId) 
        : base(cupomId) { }

    public static implicit operator CupomId (int id)
    {
        return new CupomId(id);
    }

    public static implicit operator int(CupomId cupomId)
    {
        return cupomId.Id;
    }
}
