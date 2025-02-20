using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Links.Events;

public class LinkAtualizadoEvent : EventNotification
{
    public LinkAtualizadoEvent(Guid key, string nome)
    {
        Key = key;
        Nome = nome;
    }

    public Guid Key { get; }

    public string Nome { get; }
}
