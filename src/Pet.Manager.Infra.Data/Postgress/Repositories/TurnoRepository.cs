using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class TurnoRepository : Repository<Turno, TurnoId>, ITurnoRepository
{
    public TurnoRepository(ServicoDbContext dbContext ) : base(dbContext)
    {
    }
}
