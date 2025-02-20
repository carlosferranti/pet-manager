using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Infra.Data.Postgress.Context;
using Anima.Inscricao.IoC;
using Anima.Inscricao.IoC.Extensions;

using MediatR.NotificationPublishers;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.Extensions;

public class ServiceExtensions
{
    public ServiceProvider BuildServiceProvider(ServiceCollection services)
    {
        services
            .AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assemblies.Application);
                cfg.NotificationPublisher = new TaskWhenAllPublisher();
                cfg.NotificationPublisherType = typeof(TaskWhenAllPublisher);
            });

        services.AddLogging();

        services.AddDbContext<ServicoDbContext>(options =>
        {
            options.UseInMemoryDatabase("ServicoInscricao");
        });

        services.AdicionarRepositorios();
        services.AdicionarUnitOfWork();
        services.AdicionarApplicationValidators();
        services.AdicionarDomainValidators();

        var serviceProvider = services.BuildServiceProvider();

        ValidatorProvider
            .Initialize(serviceProvider);

        return serviceProvider;
    }
}
