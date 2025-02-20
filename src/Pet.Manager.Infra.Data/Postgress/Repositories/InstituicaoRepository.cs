using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class InstituicaoRepository : Repository<Instituicao, InstituicaoId>, IInstituicaoRepository
{
    public InstituicaoRepository(ServicoDbContext dbContext) 
        : base(dbContext)
    {
    }
}
