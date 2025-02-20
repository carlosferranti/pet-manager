using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class FichaRepository : Repository<Ficha, FichaId>, IFichaRepository
{
    public FichaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
