using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class ConcursoRepository : Repository<Concurso, ConcursoId>, IConcursoRepository
{
    public ConcursoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
