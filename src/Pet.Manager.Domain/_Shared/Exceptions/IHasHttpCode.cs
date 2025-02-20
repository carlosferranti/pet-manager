using System.Net;

namespace Anima.Inscricao.Domain._Shared.Exceptions;

public interface IHasHttpCode
{
    public HttpStatusCode StatusCode { get; }
}
