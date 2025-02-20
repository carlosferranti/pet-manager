using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Cupons.Entities;

public record IntegracamCupomId : EntityId
{
    public IntegracamCupomId(int integracamCupomId)
        : base(integracamCupomId) { }

    public static implicit operator IntegracamCupomId(int id)
    {
        return new IntegracamCupomId(id);
    }
    public static implicit operator int(IntegracamCupomId integracamCupomId)
    {
        return integracamCupomId.Id;
    }
}
