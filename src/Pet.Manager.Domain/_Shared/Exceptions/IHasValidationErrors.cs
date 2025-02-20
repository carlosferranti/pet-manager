namespace Anima.Inscricao.Domain._Shared.Exceptions;

public interface IHasValidationErrors
{
    IEnumerable<ValidationExceptionInfo> ValidationInfo { get; }
}
