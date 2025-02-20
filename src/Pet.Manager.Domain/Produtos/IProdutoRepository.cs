using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Produtos;

public interface IProdutoRepository : IRepository<Produto, ProdutoId>
{
}
