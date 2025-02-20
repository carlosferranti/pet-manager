using Microsoft.Extensions.Configuration;

using Moq;

namespace Anima.Inscricao.Test.Builder;

public class ConfigBuilder
{
    private readonly Mock<IConfiguration> _configuration = new();

    public ConfigBuilder ConfiguracaoSecretKey(string secretKey)
    {
        _configuration.Setup(c => c.GetSection("JwtToken:Secret").Value)
                      .Returns(secretKey);
        return this;
    }

    public ConfigBuilder ConfiguracaoExpirationTime(string expirationTime)
    {
        _configuration.Setup(c => c.GetSection("JwtToken:ExpiracaoEmHoras").Value)
                      .Returns(expirationTime);
        return this;
    }

    public IConfiguration ConfigBuild()
    {
        return _configuration.Object;
    }
}
