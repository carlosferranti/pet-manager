using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class FormaEntradaRepository : Repository<FormaEntrada, FormaEntradaId>, IFormaEntradaRepository
{
    public FormaEntradaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}