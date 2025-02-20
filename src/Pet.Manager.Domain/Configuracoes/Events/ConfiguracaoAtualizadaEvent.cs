using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Configuracoes.Events;

public class ConfiguracaoAtualizadaEvent : EventNotification
{
    public ConfiguracaoAtualizadaEvent(Guid key, string chaveGenerica, string valor)
    {
        Key = key;
        ChaveGenerica = chaveGenerica;
        Valor = valor;
    }

    public Guid Key { get; }

    public string ChaveGenerica { get; }

    public string Valor { get; }
}