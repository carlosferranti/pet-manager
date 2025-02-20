using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class IntakeRepository : Repository<Intake, IntakeId>, IIntakeRepository
{
    public IntakeRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}