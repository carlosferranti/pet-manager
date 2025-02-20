using System.Collections;

namespace Anima.Inscricao.Domain._Shared.Exceptions;

public interface IHasErrorData
{
    public IDictionary Data { get; }
}
