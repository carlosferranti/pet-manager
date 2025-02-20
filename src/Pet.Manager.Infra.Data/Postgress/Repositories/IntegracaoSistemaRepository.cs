using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class IntegracaoSistemaRepository : Repository<IntegracaoSistema, IntegracaoSistemaId>, IIntegracaoSistemaRepository
{
    public IntegracaoSistemaRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
