using Microsoft.Extensions.Logging;

using System.Net;
using System.Runtime.Serialization;

namespace Anima.Inscricao.Domain._Shared.Exceptions;

/// <summary>
/// Base exception for business specific exceptions.
/// </summary>
[Serializable]
public class BusinessException : BaseException, IHasHttpCode
{
    public BusinessException()
        : base("Business Exception")
    {
    }

    public BusinessException(string code)
        : base("Business Exception")
    {
        Code = code;
    }

    public BusinessException(string message, string code)
    : base(message)
    {
        Code = code;
    }

    public BusinessException(string message, string code, string details)
    : base(message)
    {
        Code = code;
        Details = details;
    }

    public BusinessException(string message, string code, string details, Exception innerException)
        : base(message, innerException)
    {
        Code = code;
        Details = details;
    }

    public BusinessException(string message, string code, string details, Exception innerException, LogLevel logLevel)
        : base(message, innerException)
    {
        Code = code;
        Details = details;
        LogLevel = logLevel;
    }

    protected BusinessException(SerializationInfo serializationInfo, StreamingContext context)
        : base(serializationInfo, context)
    {
    }

    /// <summary>
    /// Obtém ou define um código para excessão.
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Obtém ou define como a excessão deverá ser tratada pelo log da aplicação.
    /// </summary>
    public LogLevel LogLevel { get; set; }

    /// <summary>
    /// Obtém ou define detalhed da exceção informando qual regra de negócio não foi respeitada.
    /// </summary>
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Obtém o status da resposta.
    /// </summary>
    public HttpStatusCode StatusCode => HttpStatusCode.UnprocessableEntity;

    /// <summary>
    ///  Allows inserting informative data about the exception.
    /// </summary>
    public BusinessException WithData(string name, object value)
    {
        Data[name] = value;
        return this;
    }
}
