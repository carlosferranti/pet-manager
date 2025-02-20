using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Produtos.Entities;

public record ProdutoId : EntityId
{
    public ProdutoId(int produtoID) : base(produtoID)
    {
    }

    public static implicit operator ProdutoId(int id)
    {
        return new ProdutoId(id);
    }

    public static implicit operator int(ProdutoId produtoId)
    {
        return produtoId.Id;
    }

}
