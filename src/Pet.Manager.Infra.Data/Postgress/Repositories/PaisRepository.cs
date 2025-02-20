using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class PaisRepository : Repository<Pais, PaisId>, IPaisRepository
{
    public PaisRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
