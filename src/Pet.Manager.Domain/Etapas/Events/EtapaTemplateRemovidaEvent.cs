using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Etapas.Events;

public class EtapaTemplateRemovidaEvent : EventNotification
{
    public EtapaTemplateRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
