namespace Anima.Inscricao.Domain._Shared.Exceptions;

public class ValidationExceptionInfo
{
    public ValidationExceptionInfo(string message, string[] members)
    {
        Message = message;
        Members = members;
    }

    /// <summary>
    /// Obtém ou define a mensagem de erro.
    /// </summary>
    public string Message { get; protected set; }

    /// <summary>
    /// Obtém ou define os nomes dos membros que causaram o erro de validação.
    /// </summary>
    public string[] Members { get; protected set; }
}
