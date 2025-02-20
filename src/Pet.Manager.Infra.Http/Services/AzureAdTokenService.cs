using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.Interfaces.Services;

using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Anima.Inscricao.Infra.Http.Services;

public class AzureAdTokenService : IAzureAdTokenService
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _authority;
    private readonly string _scope;

    public AzureAdTokenService(IOptions<AzureAdEnemConfig> azureAdConfig)
    {
        _authority = azureAdConfig.Value.Authority ?? throw new ArgumentNullException(_authority);
        _clientId = azureAdConfig.Value.ClientId ?? throw new ArgumentNullException(_clientId);
        _clientSecret = azureAdConfig.Value.ClientSecret ?? throw new ArgumentNullException(_clientSecret);
        _scope = azureAdConfig.Value.Scope ?? throw new ArgumentNullException(_scope);
    }

    public async Task<string> ObterTokenAzureAdAsync()
    {
        IConfidentialClientApplication app = ConfidentialClientApplicationBuilder.Create(_clientId)
                                                        .WithClientSecret(_clientSecret)
                                                        .WithAuthority(_authority)
                                                        .Build();
        string[] escopo = new string[] { _scope };

        AuthenticationResult resultado = await app.AcquireTokenForClient(escopo).ExecuteAsync();

        return resultado.AccessToken;
    }
}
