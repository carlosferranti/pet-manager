using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class TipoFormacaoRepository : Repository<TipoFormacao, TipoFormacaoId>, ITipoFormacaoRepository
{
    public TipoFormacaoRepository(ServicoDbContext dbContext) 
        : base(dbContext)
    {
    }
}
