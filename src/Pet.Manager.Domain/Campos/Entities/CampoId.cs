using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Campos.Entities;

public record CampoId : EntityId
{
    public CampoId(int campoFichaId)
        : base(campoFichaId) { }

    public static implicit operator CampoId(int id)
    {
        return new CampoId(id);
    }
    public static implicit operator int(CampoId campoFichaId)
    {
        return campoFichaId.Id;
    }
}