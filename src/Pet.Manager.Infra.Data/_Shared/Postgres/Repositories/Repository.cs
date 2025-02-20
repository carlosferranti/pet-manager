using System.Linq.Expressions;

using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Exceptions;
using Anima.Inscricao.Infra.Data._Shared.Postgres.Hash;

using Microsoft.EntityFrameworkCore;

namespace Anima.Inscricao.Infra.Data._Shared.Postgres.Repositories;

public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    where TKey : EntityId
    where TEntity : Entity<TKey>
{
    private readonly DbContext _dbContext;
    private readonly HashValueValidatorFactory _hashValueValidatorFactory;

    public Repository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _hashValueValidatorFactory = new HashValueValidatorFactory(dbContext);
    }

    protected DbContext Context => _dbContext;

    public async Task<TEntity?> FindAsyncWithDetails(TKey id, params Expression<Func<TEntity, object?>>[] propertySelectors)
        => await WithDetails(propertySelectors)
            .Where(o => o.Id == id)
            .SingleOrDefaultAsync();

    public async Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate)
        => await _dbContext
            .Set<TEntity>()
            .Where(predicate)
            .ApplySoftDeleteFilter()
            .SingleOrDefaultAsync();

    public async Task<TEntity?> FindAsync(TKey id)
    => await _dbContext
        .Set<TEntity>()
        .Where(e => e.Id.Equals(id))
        .ApplySoftDeleteFilter()
        .SingleOrDefaultAsync();

    public async Task<TEntity> GetAsyncWithDetails(TKey id, params Expression<Func<TEntity, object?>>[] propertySelectors)
        => await FindAsyncWithDetails(id, propertySelectors) ?? throw new EntityNotFoundException(typeof(TEntity), id);

    public async Task<TEntity> GetAsyncWithDetails(Guid key, params Expression<Func<TEntity, object?>>[] propertySelectors)
      => await FindAsyncWithDetails(key, propertySelectors) ?? throw new EntityNotFoundException(typeof(TEntity), key);

    public async Task<TKey> GetIdAsync(Guid alternateKey)
    {
        if (!typeof(IHasAlternateKey).IsAssignableFrom(typeof(TEntity)))
            throw new InvalidOperationException($"Entity type {typeof(TEntity).Name} does not implement IHasAlternateKey.");

        return await _dbContext
            .Set<TEntity>()
            .Where(e => ((IHasAlternateKey)e).Key == alternateKey)
            .ApplySoftDeleteFilter()
            .Select(e => e.Id)
            .SingleAsync();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true)
        => await FindAsync(predicate) ?? throw new EntityNotFoundException(typeof(TEntity));

    public async Task<TEntity> GetAsync(TKey id)
        => await FindAsync(id) ?? throw new EntityNotFoundException(typeof(TEntity), id);

    public async Task<TEntity> GetAsync(Guid key)
        => await FindAsync(key) ?? throw new EntityNotFoundException(typeof(TEntity), key);

    public async Task<TEntity?> FindAsync(Guid key)
    {
        if (typeof(IHasAlternateKey).IsAssignableFrom(typeof(TEntity)))
        {
            return await _dbContext
                .Set<TEntity>()
                .Where(e => ((IHasAlternateKey)e).Key == key)
                .ApplySoftDeleteFilter()
                .SingleOrDefaultAsync();
        }
        throw new InvalidOperationException($"Entity type {typeof(TEntity).Name} does not implement IHasAlternateKey.");
    }

    public async Task<IEnumerable<TEntity>> GetListAsync()
        => await _dbContext
            .Set<TEntity>()
            .ApplySoftDeleteFilter()
            .ToListAsync();

    public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
         => await _dbContext
            .Set<TEntity>()
            .Where(predicate)
            .ApplySoftDeleteFilter()
            .ToListAsync();

    public async Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting)
        => await _dbContext
            .Set<TEntity>()
            .ApplySoftDeleteFilter()
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();

    public IQueryable<TEntity> GetQueryable()
        => _dbContext
            .Set<TEntity>()
            .ApplySoftDeleteFilter()
            .AsQueryable();

    public IQueryable<TEntity> WithDetails(params Expression<Func<TEntity, object?>>[] propertySelectors)
        => IncludeDetails(GetQueryable(), propertySelectors);

    public async Task<bool> ExistsAsync(TKey id)
        => await GetQueryable()
            .Where(o => o.Id == id)
            .ApplySoftDeleteFilter()
            .AsNoTracking()
            .AnyAsync();

    public async Task<bool> ExistsAsync(Guid key, CancellationToken cancellationToken)
    {
        if (typeof(IHasAlternateKey).IsAssignableFrom(typeof(TEntity)))
        {
            return await _dbContext
                .Set<TEntity>()
                .Where(e => ((IHasAlternateKey)e).Key == key)
                .ApplySoftDeleteFilter()
                .AsNoTracking()
                .AnyAsync(cancellationToken);
        }
        throw new InvalidOperationException($"Entity type {typeof(TEntity).Name} does not implement IHasAlternateKey.");
    }

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
        => await GetQueryable()
            .Where(predicate)
            .ApplySoftDeleteFilter()
            .AsNoTracking()
            .AnyAsync();

    public async Task InsertAsync(TEntity entity)
    {
        if (entity is IValidatedHashValue validatedHashValueEntity)
        {
            var hashValidator = _hashValueValidatorFactory.Create(entity);
            if (hashValidator is not null)
                await validatedHashValueEntity.GenerateHashAsync(hashValidator);
        }
        await _dbContext.Set<TEntity>().AddAsync(entity);
    }

    public async Task InsertAsync(IEnumerable<TEntity> entities)
    {
        var groupsValidatedHashEntites = entities
            .OfType<IValidatedHashValue>()
            .GroupBy(e => e.GetType());

        foreach (var group in groupsValidatedHashEntites)
        {
            var hashValidator = _hashValueValidatorFactory.Create(group.Key);
            if (hashValidator is not null)
            {
                foreach (var entity in group)
                {
                    await entity.GenerateHashAsync(hashValidator);
                }
            }
        }
        await _dbContext.Set<TEntity>().AddRangeAsync(entities);
    }

    public void Update(TEntity entity)
    {
        if (entity is IAuditable auditableEntity)
            auditableEntity.Auditoria.AtualizarAuditoria();

        _dbContext.Attach(entity);
        _dbContext.Update(entity);
    }

    public void Update(IEnumerable<TEntity> entities)
    {
        foreach (var entity in entities)
            if (entity is IAuditable auditableEntity)
                auditableEntity.Auditoria.AtualizarAuditoria();

        _dbContext.Set<TEntity>().UpdateRange(entities);
    }

    public void Delete(TEntity entity)
    {
        if (entity is IAuditable auditableEntity)
            auditableEntity.Auditoria.AtualizarAuditoria();

        if (entity is ISoftDelete softDeleteEntity)
        {
            softDeleteEntity.Status.MarcarComoExcluido();
            _dbContext
                .Set<TEntity>()
                .Update(entity);
        }
        else
        {
            _dbContext
                .Set<TEntity>()
                .Remove(entity);
        }
    }

    public void Delete(IEnumerable<TEntity> entities)
    {
        var entitiesList = entities.ToList();
        var auditableEntities = entitiesList.OfType<IAuditable>().ToList();
        var softDeleteEntities = entitiesList.OfType<ISoftDelete>().ToList();
        var hardDeleteEntities = entitiesList.Except(softDeleteEntities.Cast<TEntity>()).ToList();

        softDeleteEntities.ForEach(entity =>
        {
            auditableEntities.ForEach(entity => entity.Auditoria.AtualizarAuditoria());

            entity.Status.MarcarComoExcluido();
            _dbContext.Set<TEntity>().Update((TEntity)entity);
        });

        if (hardDeleteEntities.Any())
        {
            _dbContext.Set<TEntity>().RemoveRange(hardDeleteEntities);
        }
    }

    private static IQueryable<TEntity> IncludeDetails(IQueryable<TEntity> query, Expression<Func<TEntity, object?>>[] propertySelectors)
    {
        if (propertySelectors != null)
        {
            foreach (var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }
        }

        return query;
    }

    public async Task<TEntity?> FindAsyncWithDetails(Guid key, params Expression<Func<TEntity, object?>>[] propertySelectors)
    {
        if (typeof(IHasAlternateKey).IsAssignableFrom(typeof(TEntity)))
        {
            return await WithDetails(propertySelectors)
                .Where(e => ((IHasAlternateKey)e).Key == key)
                .ApplySoftDeleteFilter()
                .SingleOrDefaultAsync();
        }
        throw new InvalidOperationException($"Entity type {typeof(TEntity).Name} does not implement IHasAlternateKey.");
    }
}

public static class QueryableExtensions
{
    public static IQueryable<TEntity> ApplySoftDeleteFilter<TEntity>(this IQueryable<TEntity> query)
        where TEntity : class
    {
        if (typeof(ISoftDelete).IsAssignableFrom(typeof(TEntity)))
        {
            var parameter = Expression.Parameter(typeof(TEntity), "entity");
            var statusProperty = Expression.Property(parameter, nameof(ISoftDelete.Status));
            var ativoProperty = Expression.Property(statusProperty, nameof(Status.Ativo));
            var ativoCondition = Expression.Equal(ativoProperty, Expression.Constant(true));
            var lambda = Expression.Lambda<Func<TEntity, bool>>(ativoCondition, parameter);

            return query.Where(lambda);
        }

        return query;
    }
}