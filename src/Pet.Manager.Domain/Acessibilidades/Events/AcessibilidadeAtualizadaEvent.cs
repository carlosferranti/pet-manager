using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Acessibilidades.Events;

public class AcessibilidadeAtualizadaEvent : EventNotification
{
    public AcessibilidadeAtualizadaEvent(Guid key, string nome)
    {
        Key = key;
        Nome = nome;
    }
    public Guid Key { get;}

    public string Nome { get; }
}
