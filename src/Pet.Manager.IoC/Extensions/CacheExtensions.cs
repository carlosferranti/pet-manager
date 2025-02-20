using Anima.Componente.CustomDistributedCache.Extensions;
using Anima.Inscricao.Application.Cache;
using Anima.Inscricao.Application.Cache.Persistence;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class CacheExtensions
{
    internal static IServiceCollection AdicionarCache(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigurarCacheDistribuido(configuration);
        services.ConfigurarCacheMemoria();
        services.AddTransient(typeof(ICacheBuilder<,>), typeof(CacheBuilder<,>));

        return services;
    }

    private static void ConfigurarCacheDistribuido(this IServiceCollection services, IConfiguration configuration)
    {
        var environment = configuration["ASPNETCORE_ENVIRONMENT"];
        var localCacheEnvironments = new[] { "local", "staging" };

        if (localCacheEnvironments.Any(env => env.Equals(environment, StringComparison.OrdinalIgnoreCase)))
        {
            services.AddDistributedMemoryCache();
        }
        else
        {
            services.AddCustomDistributedRedisCache(config =>
            {
                config.ConnectionString = configuration.GetConnectionString("RedisDatabase");
            });
        }
    }

    private static void ConfigurarCacheMemoria(this IServiceCollection services)
    {
        services.AddMemoryCache();
    }
}
