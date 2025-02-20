using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

using Anima.Inscricao.Application.Config;

using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Authentications.Basic;

public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly BasicAuthenticationConfig _basicAuthenticationConfig;

    public BasicAuthenticationHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        IOptions<BasicAuthenticationConfig> basicAuthenticationConfig,
        ILoggerFactory logger,
        UrlEncoder encoder)
        : base(options, logger, encoder)
    {
        _basicAuthenticationConfig = basicAuthenticationConfig.Value;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            return await Task.FromResult(AuthenticateResult.Fail("Unauthorized"));
        }

        string authorizationHeader = Request.Headers["Authorization"];
        if (string.IsNullOrEmpty(authorizationHeader))
        {
            return await Task.FromResult(AuthenticateResult.Fail("Unauthorized"));
        }

        if (!authorizationHeader.StartsWith("basic ", StringComparison.OrdinalIgnoreCase))
        {
            return await Task.FromResult(AuthenticateResult.Fail("Unauthorized"));
        }

        var token = authorizationHeader.Substring(6);
        var credenciaisString = Encoding.UTF8.GetString(Convert.FromBase64String(token));

        var credenciais = credenciaisString.Split(":");
        if (credenciais?.Length != 2)
        {
            return await Task.FromResult(AuthenticateResult.Fail("Unauthorized"));  
        }

        var usuario = credenciais[0];
        var senha = credenciais[1];

        if (usuario != _basicAuthenticationConfig.Usuario ||
            senha != _basicAuthenticationConfig.Senha)
        {
            return await Task.FromResult(AuthenticateResult.Fail("Authentication failed"));
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, usuario)
        };

        var identity = new ClaimsIdentity(claims, BasicAuthenticationDefaults.AuthenticationSchemes);

        var claimsPrincipal = new ClaimsPrincipal(identity);

        return await Task.FromResult(
            AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal, Scheme.Name)));
    }
}