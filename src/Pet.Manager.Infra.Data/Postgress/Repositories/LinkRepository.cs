using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class LinkRepository : Repository<Link, LinkId>, ILinkRepository
{
    public LinkRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}