using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Acessibilidades.Entities;

public record AcessibilidadeId : EntityId
{
    public AcessibilidadeId(int acessibilidadeId)
        : base(acessibilidadeId) { }

    public static implicit operator AcessibilidadeId(int id)
    {
        return new AcessibilidadeId(id);
    }
    public static implicit operator int(AcessibilidadeId acessibilidadeId)
    {
        return acessibilidadeId.Id;
    }
}
