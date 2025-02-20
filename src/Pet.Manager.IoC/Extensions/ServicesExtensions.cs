using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Infra.Http.Services;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class ServicesExtensions
{
    internal static IServiceCollection AdicionarServicos(this IServiceCollection services, IConfiguration configuration)
    {
        #region Azure
        services.AddScoped<IAzureAdTokenService, AzureAdTokenService>();
        #endregion

        #region Aws
        services.AddScoped<IAmazonS3Service, AmazonS3Service>();
        #endregion

        #region Enem
        services.AddScoped<IEnemService, EnemService>();
        services.AddHttpClient<EnemService>();
        #endregion

        return services;
    }
}

