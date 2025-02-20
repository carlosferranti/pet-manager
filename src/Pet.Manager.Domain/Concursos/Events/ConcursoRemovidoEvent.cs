using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Concursos.Events;

public class ConcursoRemovidoEvent : EventNotification
{
    public ConcursoRemovidoEvent(Guid key)
    {
        Key = key;
    }

    public Guid Key { get; }
}