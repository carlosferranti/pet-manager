using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC.Extensions;

internal static class ProviderExtensions
{
    internal static IServiceCollection AdicionarProviderExtensions(this IServiceCollection services)
    {
        ValidatorProvider
            .Initialize(services.BuildServiceProvider());

        services
            .AddScoped<IKafkaFactory, KafkaFactory>();

        return services;
    }
}

