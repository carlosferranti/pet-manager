using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class EscolaRepository : Repository<Escola, EscolaId>, IEscolaRepository
{
    public EscolaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
