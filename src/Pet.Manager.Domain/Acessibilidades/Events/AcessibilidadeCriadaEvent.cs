using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Acessibilidades.Events;

public class AcessibilidadeCriadaEvent : EventNotification
{
    public AcessibilidadeCriadaEvent(Guid key, string nome)
    {
        Key = key;
        Nome = nome;
    }

    public Guid Key { get; }

    public string Nome { get; }
}
