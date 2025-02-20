using Anima.Inscricao.Domain._Shared.Validations;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Infra.Data._Shared.Postgres.Hash;

public class HashValueValidatorFactory
{
    private readonly DbContext _dbContext;

    public HashValueValidatorFactory(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IHashValueValidator? Create(object entity)
    {
        return entity switch
        {
            _ => null
        };
    }
}
