using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class OfertaConcursoRepository : Repository<OfertaConcurso, OfertaConcursoId>, IOfertaConcursoRepository
{
    public OfertaConcursoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
