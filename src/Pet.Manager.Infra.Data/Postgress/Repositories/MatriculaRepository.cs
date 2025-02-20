using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Matriculas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class MatriculaRepository : Repository<Matricula, MatriculaId>, IMatriculaRepository
{
    public MatriculaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}