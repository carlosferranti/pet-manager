using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public record CampoFichaId : EntityId
{
    public CampoFichaId(int campoFichaId)
        : base(campoFichaId) { }

    public static implicit operator CampoFichaId(int id)
    {
        return new CampoFichaId(id);
    }
    public static implicit operator int(CampoFichaId campoFichaId)
    {
        return campoFichaId.Id;
    }
}