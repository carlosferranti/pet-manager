using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class OfertaRepository : Repository<Oferta, OfertaId>, IOfertaRepository
{
    public OfertaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
