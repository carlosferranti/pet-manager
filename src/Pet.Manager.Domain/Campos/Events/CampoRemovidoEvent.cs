using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Campos.Events;

public class CampoRemovidoEvent : EventNotification
{
    public CampoRemovidoEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}