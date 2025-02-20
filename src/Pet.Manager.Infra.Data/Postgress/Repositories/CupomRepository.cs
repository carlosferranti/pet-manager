using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CupomRepository : Repository<Cupom, CupomId>, ICupomRepository
{
    public CupomRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
