using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Fichas.Events;

public class FichaAtualizadaEvent : EventNotification
{
    public FichaAtualizadaEvent(Guid key, string nome, string descricao, bool padrao)
    {
        Key = key;
        Nome = nome;
        Descricao = descricao;
        Padrao = padrao;
    }

    public Guid Key { get; }

    public string Nome { get; }

    public string Descricao { get; }

    public bool Padrao { get; }
}
