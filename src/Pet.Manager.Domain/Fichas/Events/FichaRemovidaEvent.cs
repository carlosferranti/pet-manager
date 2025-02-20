using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Fichas.Events;

public class FichaRemovidaEvent : EventNotification
{
    public FichaRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
