namespace Anima.Inscricao.Domain._Shared.Entities;

/// <summary>
/// Classe base para entidades genéricas.
/// </summary>
/// <typeparam name="TKey">O tipo do identificador da entidade.</typeparam>
public abstract class Entity<TKey> : IComparable<Entity<TKey>>
    where TKey : EntityId
{
    //private readonly  List<Notification> _notifications = new();

    //protected void RegisterNotification(string atributo, string codigoErro, string mensagem)
    //{
    //    _notifications.Add(new Notification(atributo, codigoErro, mensagem));
    //}

    //protected void RegisterNotification(IEnumerable<Notification> novasNotificacoes)
    //{
    //    _notifications.AddRange(novasNotificacoes);
    //}

    //public IEnumerable<Notification> GetNotification()
    //{
    //    return _notifications;
    //}

    /// <summary>
    /// Inicia uma nova instância da classe <see cref="Entity{TKey}"/>.
    /// </summary>
    protected Entity()
        => Id = null!;

    /// <summary>
    /// Inicia uma nova instância da classe <see cref="Entity{TKey}"/> com um identificador.
    /// </summary>
    /// <param name="id">O identificador da entidade.</param>
    protected Entity(TKey id)
        => Id = id;

    /// <summary>
    /// Obtém ou define o identificador da entidade.
    /// </summary>
    public TKey Id { get; protected set; }

    /// <summary>
    /// Compara a instância atual com outro objeto do mesmo tipo e retorna um inteiro que indica se a instância atual precede, segue ou ocorre na mesma posição na ordem de classificação que o outro objeto.
    /// </summary>
    /// <param name="other">O objeto a ser comparado.</param>
    /// <returns>Um valor que indica a ordem relativa das instâncias comparadas.</returns>
    public int CompareTo(Entity<TKey>? other)
    {
        if (other == null)
            return 1;

        return Id.CompareTo(other.Id);
    }

    /// <summary>
    /// Determina se dois objetos de entidade são iguais.
    /// </summary>
    /// <param name="obj">O objeto a ser comparado com o atual objeto.</param>
    /// <returns>true se os objetos são iguais; caso contrário, false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is Entity<TKey> other)
        {
            return Id.Equals(other.Id);
        }

        return false;
    }

    /// <summary>
    /// Retorna um código hash para o objeto atual.
    /// </summary>
    /// <returns>Um código hash para o objeto atual.</returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    /// <summary>
    /// Retorna uma string que representa o objeto atual.
    /// </summary>
    /// <returns>Uma string que representa o objeto atual.</returns>
    public override string ToString()
    {
        return $"{GetType().Name} [Id={Id}]";
    }


}