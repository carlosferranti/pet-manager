using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class NivelCursoRepository : Repository<NivelCurso, NivelCursoId>, INivelCursoRepository
{
    public NivelCursoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
