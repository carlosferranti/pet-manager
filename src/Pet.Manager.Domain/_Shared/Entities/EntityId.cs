namespace Anima.Inscricao.Domain._Shared.Entities;

public record EntityId : IEquatable<EntityId>, IComparable<EntityId>
{
    public EntityId(int id)
    {
        Id = id;
    }

    protected EntityId()
    {
    }

    public int Id { get; protected set; }

    public int CompareTo(EntityId? other)
    {
        if (other == null) return 1;
        return Id.CompareTo(other.Id);
    }

    public virtual bool Equals(EntityId? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return Id.ToString();
    }
}
