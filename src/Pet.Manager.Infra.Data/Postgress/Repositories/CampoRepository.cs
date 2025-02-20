using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class CampoRepository : Repository<Campo, CampoId>, ICampoRepository
{
    public CampoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}