using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Configuracoes.Events;

public class ConfiguracaoRemovidaEvent : EventNotification
{
    public ConfiguracaoRemovidaEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}
