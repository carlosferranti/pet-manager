using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public record EtapaFichaId : EntityId
{
    public EtapaFichaId(int etapaFichaId)
        : base(etapaFichaId) { }

    public static implicit operator EtapaFichaId(int id)
    {
        return new EtapaFichaId(id);
    }
    public static implicit operator int(EtapaFichaId etapaFichaId)
    {
        return etapaFichaId.Id;
    }
}
