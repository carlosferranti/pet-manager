using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Marcas.Events;

public class MarcaAtualizadaEvent : EventNotification
{
    public MarcaAtualizadaEvent(Guid key, string nome, string sigla)
    {
        Key = key;
        Nome = nome;
        Sigla = sigla;
    }

    public Guid Key { get; }

    public string Nome { get; }

    public string Sigla { get; }
}
