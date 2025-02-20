using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Acessibilidades.Events;

public class AcessibilidadeRemovidaEvent : EventNotification
{
    public AcessibilidadeRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
