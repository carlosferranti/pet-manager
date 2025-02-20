using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation;

using MediatR;

namespace Anima.Inscricao.Application._Shared.Validations;

public abstract class ApplicationRequestValidator<TRequest> : AbstractValidator<TRequest>, IPipelineBehavior<TRequest, Unit>
    where TRequest : IRequest
{
    private readonly INotificationContext _notificationContext;

    protected ApplicationRequestValidator(INotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public async Task<Unit> Handle(TRequest request, RequestHandlerDelegate<Unit> next, CancellationToken cancellationToken)
    {
        var retorno = await ValidateAsync(request, cancellationToken);

        if (retorno.IsValid)
        {
            return await next();
        }
        else
        {
            _notificationContext.AddNotifications(retorno);

            return Unit.Value;
        }
    }
}

public abstract class ApplicationRequestValidator<TRequest, TResponse> : AbstractValidator<TRequest>, IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly INotificationContext _notificationContext;

    protected ApplicationRequestValidator(INotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var retorno = await ValidateAsync(request, cancellationToken);

        if (retorno.IsValid)
        {
            return await next();
        }
        else
        {
            _notificationContext.AddNotifications(retorno);
            return default;
        }
    }
}
