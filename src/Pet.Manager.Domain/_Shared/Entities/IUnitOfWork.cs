using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain._Shared.Entities;

public interface IUnitOfWork
{
    Task<int> CommitAsync(CancellationToken cancellationToken = default);

    Task PublishDomainEventsAsync(IGeneratesDomainEvents entity, CancellationToken cancellationToken = default);
}
