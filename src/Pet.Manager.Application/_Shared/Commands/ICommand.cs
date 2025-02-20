using MediatR;

namespace Anima.Inscricao.Application._Shared.Commands;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
