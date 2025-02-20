using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Ofertas.Events;

public class OfertaRemovidaEvent : EventNotification
{
    public OfertaRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
