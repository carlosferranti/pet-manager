using System.Runtime.Serialization;

namespace Anima.Inscricao.Domain._Shared.Exceptions;

/// <summary>
/// Base exception for application specific exceptions.
/// </summary>
public abstract class BaseException : Exception
{
    protected BaseException()
    {
    }

    protected BaseException(string message)
        : base(message)
    {
    }

    protected BaseException(string message, Exception? innerException)
        : base(message, innerException)
    {
    }

    protected BaseException(SerializationInfo serializationInfo, StreamingContext context)
        : base(serializationInfo, context)
    {
    }
}
