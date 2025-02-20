using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Cupons.Events;

public class CupomRemovidoEvent : EventNotification
{
    public CupomRemovidoEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; set; }
}
