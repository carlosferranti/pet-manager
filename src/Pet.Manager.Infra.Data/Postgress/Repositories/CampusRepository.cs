using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CampusRepository : Repository<Campus, CampusId>, ICampusRepository
{
    public CampusRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
