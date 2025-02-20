using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Acessibilidades.Entities;

public record IntegracaoAcessibilidadeId : EntityId
{
    public IntegracaoAcessibilidadeId(int integracaoAcessibilidadeId)
        : base(integracaoAcessibilidadeId) { }

    public static implicit operator IntegracaoAcessibilidadeId(int id)
    {
        return new IntegracaoAcessibilidadeId(id);
    }
    public static implicit operator int(IntegracaoAcessibilidadeId integracaoAcessibilidadeId)
    {
        return integracaoAcessibilidadeId.Id;
    }
}
