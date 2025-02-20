using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class ModalidadeRepository : Repository<Modalidade, ModalidadeId>, IModalidadeRepository
{
    public ModalidadeRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}
