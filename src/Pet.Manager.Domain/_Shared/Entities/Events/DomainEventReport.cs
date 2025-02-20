namespace Anima.Inscricao.Domain._Shared.Entities.Events;

public class DomainEventReport
{
    public DomainEventReport()
    {
        Events = new List<DomainEvent>();
    }

    public List<DomainEvent> Events { get; }

    public override string ToString()
    {
        return $"[{nameof(DomainEventReport)}] DomainEvents: {Events.Count} ";
    }
}
