using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CidadeRepository : Repository<Cidade, CidadeId>, ICidadeRepository
{
    public CidadeRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}

