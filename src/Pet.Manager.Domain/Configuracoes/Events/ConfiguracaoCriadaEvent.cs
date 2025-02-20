using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Configuracoes.Events;

public class ConfiguracaoCriadaEvent : EventNotification
{
    public ConfiguracaoCriadaEvent(Guid key, string chave, string valor)
    {
        Key = key;
        Chave = chave;
        Valor = valor;
    }

    public Guid Key { get; }

    public string Chave { get; }

    public string Valor { get; }
}
