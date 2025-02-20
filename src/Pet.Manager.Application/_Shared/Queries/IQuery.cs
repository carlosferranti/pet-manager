using MediatR;

namespace Anima.Inscricao.Application._Shared.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}
