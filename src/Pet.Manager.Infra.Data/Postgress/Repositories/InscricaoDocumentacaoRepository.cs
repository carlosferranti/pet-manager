using Anima.Inscricao.Domain.Inscricoes;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class InscricaoDocumentacaoRepository : Repository<DocumentacaoInscricao, DocumentacaoInscricaoId>, IInscricaoDocumentacaoRepository
{
    public InscricaoDocumentacaoRepository(ServicoDbContext dbContext) 
        : base(dbContext)
    {
    }
}