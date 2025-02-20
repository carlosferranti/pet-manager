using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Infra.Data.Postgress.Context;

namespace Anima.Inscricao.Infra.Data._Shared.Postgres.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly ServicoDbContext _dbContext;

    public UnitOfWork(ServicoDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        => await _dbContext.SaveChangesAsync(cancellationToken);

    public async Task PublishDomainEventsAsync(IGeneratesDomainEvents entity, CancellationToken cancellationToken = default)
    {
        var eventReport = new DomainEventReport();

        var domainEvents = entity.GetEvents()?.ToArray();

        if (domainEvents != null && domainEvents.Any())
        {
            eventReport.Events.AddRange(domainEvents.ToList());
            entity.ClearEvents();
        }

        await _dbContext.PublishEntityEvents(eventReport, cancellationToken);
    }
}
