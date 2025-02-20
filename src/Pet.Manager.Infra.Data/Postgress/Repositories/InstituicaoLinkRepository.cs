using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;
using Anima.Inscricao.Infra.Data.Postgress.Context;

using Microsoft.EntityFrameworkCore;

using Npgsql;

namespace Anima.Inscricao.Infra.Data.Postgress.Repositories;

public class InstituicaoLinkRepository : Repository<InstituicaoLink, InstituicaoLinkId>, IInstituicaoLinkRepository
{
    private const string SistemaOrigem = "Vestib";
    public InstituicaoLinkRepository(ServicoDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<InstituicaoLink> ObterInstituicaoLinkAsync(Guid Key,string TipoLink,  CancellationToken cancellationToken)
    {
        try
        {
            string sql = $@"SELECT distinct li.*
            FROM ""InscricaoCandidato"" i
            INNER join ""InstituicaoLink"" li on li.""MarcaId"" = i.""MarcaId"" 
            WHERE i.""Key"" = @Key
            AND li.""TipoLink"" = @TipoLink
            AND li.""Ativo"" = 'True'";

            object[] parametros =
            {
            new NpgsqlParameter("@Key", Key),
            new NpgsqlParameter("@SistemaOrigem", SistemaOrigem),
            new NpgsqlParameter("@TipoLink", TipoLink),
            
            
        };

            return await Context
            .Set<InstituicaoLink>()
            .FromSqlRaw(sql, parametros)
            .SingleOrDefaultAsync(cancellationToken);

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
}
