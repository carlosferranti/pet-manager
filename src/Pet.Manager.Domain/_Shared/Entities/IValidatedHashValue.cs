using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain._Shared.Entities;

public interface IValidatedHashValue
{
    byte[] HashValue { get; }
    Task GenerateHashAsync(IHashValueValidator hashValueValidator);
}
