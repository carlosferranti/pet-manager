using Anima.Inscricao.IoC.Extensions;

using MediatR.NotificationPublishers;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.IoC;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection RegistraDependencias(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddMediatR(cfg => {
                cfg.RegisterServicesFromAssemblies(Assemblies.Application);
                cfg.RegisterServicesFromAssemblies(Assemblies.Messageing);
                cfg.RegisterServicesFromAssemblies(Assemblies.Http);
                cfg.NotificationPublisher = new TaskWhenAllPublisher();
                cfg.NotificationPublisherType = typeof(TaskWhenAllPublisher);
            });

        services.AddSingleton(configuration)
            .AdicionarConfiguracoes(configuration)
            .AdicionarUnitOfWork()
            .AdicionarContextoServicoInscricaoDb(configuration)
            .AdicionarContextoSiafDb(configuration)
            .AdicionarRepositorios()
            .AdicionarRepositoriosExternos()
            .AdicionarApplicationValidators()
            .AdicionarDomainValidators()
            .AdicionarCache(configuration)
            .AdicionarProviderExtensions()
            .AdicionarServicos(configuration)
            .AdicionarMapeamentos();

        return services;
    }
}

