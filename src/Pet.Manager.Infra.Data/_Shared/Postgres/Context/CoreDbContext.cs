using Anima.Inscricao.Domain._Shared.Entities.Events;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Infra.Data._Shared.Postgres.Context;

public abstract class CoreDbContext : DbContext
{
    private readonly ILogger<CoreDbContext> _logger;
    private readonly IMediator? _mediator;

    protected CoreDbContext(ILogger<CoreDbContext> logger, DbContextOptions options, IMediator? mediator)
        : base(options)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        try
        {
            var inicio = DateTime.Now;
            var result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            var termino = DateTime.Now;

            _logger.LogDebug("Tempo de {tempo} para a execução do SaveChanges", termino - inicio);

            var eventReport = CreateEventReport();
            await PublishEntityEvents(eventReport, cancellationToken);

            return result;
        }
        finally
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }
    }

    public virtual DomainEventReport CreateEventReport()
    {
        var eventReport = new DomainEventReport();

        foreach (var entry in ChangeTracker.Entries().ToList())
        {
            if (entry.Entity is not IGeneratesDomainEvents generatesDomainEventsEntity)
            {
                continue;
            }

            var domainEvents = generatesDomainEventsEntity.GetEvents()?.ToArray();
            if (domainEvents != null && domainEvents.Any())
            {
                eventReport.Events.AddRange(domainEvents.ToList());
                generatesDomainEventsEntity.ClearEvents();
            }
        }

        return eventReport;
    }

    public async Task PublishEntityEvents(DomainEventReport changeReport, CancellationToken cancellationToken)
    {
        if (_mediator == null)
        {
            _logger.LogWarning("Os eventos n�o ser�o publicados pois o mediator n�o foi ativado");
            return;
        }

        var localEvents = changeReport
            .Events
            .OrderBy(o => o.Order);

        foreach (var localEvent in localEvents)
        {
            await _mediator.Publish(localEvent.EventNotification, cancellationToken);
        }
    }
}
