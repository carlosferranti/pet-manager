namespace Anima.Inscricao.Domain._Shared.Validations;

public interface IHashValueValidator
{
    public Task<bool> ValidateExistingAsync(byte[] hashValue);
}
