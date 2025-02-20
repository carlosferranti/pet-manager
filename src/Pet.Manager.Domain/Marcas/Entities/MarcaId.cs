using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Marcas.Entities;

public record MarcaId : EntityId
{
    public MarcaId(int marcaId) 
        : base(marcaId) { }

    public static implicit operator MarcaId(int id) 
    {  
        return new MarcaId(id); 
    }
    
    public static implicit operator int(MarcaId marcaId)
    {
        return marcaId.Id;
    }
}
