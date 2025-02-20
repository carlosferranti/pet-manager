using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Links.Events;

public class LinkRemovidoEvent : EventNotification
{
    public LinkRemovidoEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}