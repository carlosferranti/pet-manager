using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Marcas.Events;

public class MarcaRemovidaEvent : EventNotification
{
    public MarcaRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
