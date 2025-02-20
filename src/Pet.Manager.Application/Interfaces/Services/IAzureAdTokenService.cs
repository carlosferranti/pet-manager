namespace Anima.Inscricao.Application.Interfaces.Services;

public interface IAzureAdTokenService
{
    Task<string> ObterTokenAzureAdAsync();
}
