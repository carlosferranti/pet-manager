using MediatR;

namespace Anima.Inscricao.Application._Shared.Commands;

public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
{
}

public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest>
    where TRequest : ICommand
{
}