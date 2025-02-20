using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CursoExternoRepository : Repository<CursoExterno, CursoExternoId>, ICursoExternoRepository
{
    public CursoExternoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
