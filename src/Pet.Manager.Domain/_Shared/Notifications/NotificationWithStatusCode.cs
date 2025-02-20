using System.Net;

namespace Anima.Inscricao.Domain._Shared.Notifications;

public class NotificationWithStatusCode : Notification
{
    public HttpStatusCode HttpCode { get; }

    public NotificationWithStatusCode(string atributo, string codigoErro, string mensagem, HttpStatusCode httpCode) : base(atributo, codigoErro, mensagem)
    {
        HttpCode = httpCode;
    }
}
