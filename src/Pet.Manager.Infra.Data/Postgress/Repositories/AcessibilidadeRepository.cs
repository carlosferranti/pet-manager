using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class AcessibilidadeRepository : Repository<Acessibilidade, AcessibilidadeId>, IAcessibilidadeRepository
{
    public AcessibilidadeRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
