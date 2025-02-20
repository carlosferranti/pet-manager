using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain._Shared.Entities;

/// <summary>
/// Classe abstrata que representa uma entidade agregada no domínio.
/// </summary>
/// <typeparam name="TEntityId">O tipo do identificador da entidade.</typeparam>
public abstract class AggregateEntity<TEntityId> : Entity<TEntityId>, IGeneratesDomainEvents
    where TEntityId : EntityId
{
    /// <summary>
    /// Lista de eventos de domínio associados a esta entidade agregada.
    /// </summary>
    private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();


    /// <summary>
    /// Inicia uma nova instância da classe <see cref="AggregateEntity{TEntityId}"/>.
    /// </summary>
    protected AggregateEntity()
        : base()
    {
    }

    /// <summary>
    /// Inicia uma nova instância da classe <see cref="AggregateEntity{TEntityId}"/>.
    /// </summary>
    /// <param name="id">O identificador da entidade.</param>
    protected AggregateEntity(TEntityId id)
        : base(id)
    {
    }

    /// <summary>
    /// Obtém a lista somente leitura de eventos de domínio associados a esta entidade agregada.
    /// </summary>
    protected IReadOnlyList<DomainEvent> DomainEvents
        => _domainEvents.AsReadOnly();

    /// <summary>
    /// Obtém todos os eventos de domínio associados a esta entidade agregada.
    /// </summary>
    /// <returns>Uma coleção de eventos de domínio.</returns>
    public IEnumerable<DomainEvent> GetEvents()
        => _domainEvents.AsEnumerable();

    /// <summary>
    /// Limpa a lista de eventos de domínio associados a esta entidade agregada.
    /// </summary>
    public virtual void ClearEvents()
        => _domainEvents.Clear();

    /// <summary>
    /// Registra um novo evento de domínio associado a esta entidade agregada.
    /// </summary>
    /// <param name="eventNotification">O evento de notificação do evento.</param>
    protected virtual void RegisterEvent(EventNotification eventNotification)
        => _domainEvents.Add(DomainEvent.Create(this, eventNotification));
}
