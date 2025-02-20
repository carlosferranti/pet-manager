using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Campos.Events;

public class CampoAtualizadoEvent : EventNotification
{
    public CampoAtualizadoEvent(Guid key, string nome)
    {
        Key = key;
        Nome = nome;
    }

    public Guid Key { get; }

    public string Nome { get; }
}
