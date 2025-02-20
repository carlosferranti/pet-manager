using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Marcas.Entities;

public record IntegracaoMarcaId : EntityId
{
    public IntegracaoMarcaId(int integracaoMarcaId) 
        : base(integracaoMarcaId) { }

    public static implicit operator IntegracaoMarcaId (int id)
    {
        return new IntegracaoMarcaId(id);
    }

    public static implicit operator int(IntegracaoMarcaId integracaoMarcaId)
    {
        return integracaoMarcaId.Id;
    }
}
