using MediatR;

namespace Anima.Inscricao.Application._Shared.Queries;

public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQuery<TResponse>
{
}
