using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Entities;

public record IntegracaoOfertaId : EntityId
{
    public IntegracaoOfertaId(int integracaoOfertaId) 
        : base(integracaoOfertaId)
    {
    }

    public static implicit operator IntegracaoOfertaId(int id)
    {
        return new IntegracaoOfertaId(id);
    }

    public static implicit operator int(IntegracaoOfertaId integracaoOfertaId)
    {
        return integracaoOfertaId.Id;
    }
}