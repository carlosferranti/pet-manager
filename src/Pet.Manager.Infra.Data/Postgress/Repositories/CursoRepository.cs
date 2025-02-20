using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CursoRepository : Repository<Curso, CursoId>, ICursoRepository
{
    public CursoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}