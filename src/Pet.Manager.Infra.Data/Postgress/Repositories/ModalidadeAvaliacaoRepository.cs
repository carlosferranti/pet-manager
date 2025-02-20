using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class ModalidadeAvaliacaoRepository : Repository<ModalidadeAvaliacao, ModalidadeAvaliacaoId>, IModalidadeAvaliacaoRepository
{
    public ModalidadeAvaliacaoRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }
}