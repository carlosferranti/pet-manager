using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Produtos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class ProdutoRepository : Repository<Produto, ProdutoId>, IProdutoRepository
{
    public ProdutoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
