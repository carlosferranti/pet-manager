namespace Anima.Inscricao.Domain._Shared.Notifications;

public class Notification
{
    public Notification(string atributo, string codigoErro, string mensagem)
    {
        Atributo = atributo;
        CodigoErro = codigoErro;
        Mensagem = mensagem;
    }

    public string Atributo { get; }

    public string CodigoErro { get; }

    public string Mensagem { get; }
}
