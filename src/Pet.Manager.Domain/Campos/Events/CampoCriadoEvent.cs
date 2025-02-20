using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Campos.Events;

public class CampoCriadoEvent : EventNotification
{
    public CampoCriadoEvent(Guid key, string nome)
    {
        Key = key;
        Nome = nome;
    }

    public Guid Key { get; }

    public string Nome { get; }
}