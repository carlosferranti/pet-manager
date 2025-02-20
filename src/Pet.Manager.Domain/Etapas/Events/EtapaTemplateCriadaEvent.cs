using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Etapas.Events;

public class EtapaTemplateCriadaEvent : EventNotification
{
    public EtapaTemplateCriadaEvent(Guid key, string nome, string descricao, string nomeArquivo)
    {
        Key = key;
        Nome = nome;
        Descricao = descricao;
        NomeArquivo = nomeArquivo;
    }

    public Guid Key { get; }

    public string Nome { get; }

    public string Descricao { get; }

    public string NomeArquivo { get; }
}
