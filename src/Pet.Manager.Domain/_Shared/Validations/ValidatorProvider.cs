using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Domain._Shared.Validations;

public class ValidatorProvider
{
    private static ValidatorProvider _instance;

    private readonly IServiceProvider _serviceProvider;

    private ValidatorProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static ValidatorProvider Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("ValidatorProvider não foi inicializado.");
            }

            return _instance;
        }
    }

    public static void Initialize(IServiceProvider serviceProvider)
    {
        if (_instance == null)
        {
            _instance = new ValidatorProvider(serviceProvider);
        }
    }

    public T GetValidator<T>()
        where T : DomainValidator
    {
        return _serviceProvider
            .CreateScope().ServiceProvider
            .GetRequiredService<T>();
    }
}
