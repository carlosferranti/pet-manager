using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public record FichaId : EntityId
{
    public FichaId(int fichaId)
        : base(fichaId) { }

    public static implicit operator FichaId(int id)
    {
        return new FichaId(id);
    }
    public static implicit operator int(FichaId fichaId)
    {
        return fichaId.Id;
    }
}
