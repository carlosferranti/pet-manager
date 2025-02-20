using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class EtapaTemplateRepository : Repository<EtapaTemplate, EtapaTemplateId>, IEtapaTemplateRepository
{
    public EtapaTemplateRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
