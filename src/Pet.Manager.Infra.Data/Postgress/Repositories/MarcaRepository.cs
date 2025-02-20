using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class MarcaRepository : Repository<Marca, MarcaId>, IMarcaRepository
{
    public MarcaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
