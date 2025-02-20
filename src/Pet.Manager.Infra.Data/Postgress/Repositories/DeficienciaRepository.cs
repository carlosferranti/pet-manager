using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class DeficienciaRepository : Repository<Deficiencia, DeficienciaId>, IDeficienciaRepository
{
    public DeficienciaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}