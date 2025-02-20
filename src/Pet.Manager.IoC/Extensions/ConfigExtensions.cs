using Anima.Inscricao.Application.Config;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class ConfigExtensions
{
    internal static IServiceCollection AdicionarConfiguracoes(
    this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddOptions();
        services.Configure<CacheConfig>(cache => configuration.Bind("Cache", cache));
        services.Configure<KafkaConfig>(kafkaConfig => configuration.Bind("Kafka", kafkaConfig));
        services.Configure<AzureAdEnemConfig>(azureAdEnemConfig => configuration.Bind("AzureAdEnem", azureAdEnemConfig));
        services.Configure<ApiProvaEnemConfig>(apiProvaEnemConfig => configuration.Bind("ApiProvaEnemConfig", apiProvaEnemConfig));
        services.Configure<AzureAdConfig>(AzureAdConfig => configuration.Bind("AzureAd", AzureAdConfig));
        services.Configure<BasicAuthenticationConfig>(basicAuthenticationConfig => configuration.Bind("BasicAuthentication", basicAuthenticationConfig));
        services.Configure<AmazonS3Config>(amazonS3Config => configuration.Bind("AmazonS3", amazonS3Config));
        return services;
    }
}
