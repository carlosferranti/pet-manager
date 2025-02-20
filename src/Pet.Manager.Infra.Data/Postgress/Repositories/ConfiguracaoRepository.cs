using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class ConfiguracaoRepository : Repository<Configuracao, ConfiguracaoId>, IConfiguracaoRepository
{
    public ConfiguracaoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
