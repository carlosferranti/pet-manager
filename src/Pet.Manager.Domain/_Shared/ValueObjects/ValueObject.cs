namespace Anima.Inscricao.Domain._Shared.ValueObjects;

using System;
using System.Collections.Generic;

#pragma warning disable S4035 // Classes implementing "IEquatable<T>" should be sealed
public abstract class ValueObject<T> : IEquatable<T>
#pragma warning restore S4035 // Classes implementing "IEquatable<T>" should be sealed
    where T : ValueObject<T>
{
    public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
        {
            return true;
        }

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
    {
        return !(a == b);
    }

#pragma warning disable S4136 // Method overloads should be grouped together
    public override bool Equals(object obj)
#pragma warning restore S4136 // Method overloads should be grouped together
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }

        var other = (T)obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        int hashCode = 17;
        foreach (var component in GetEqualityComponents())
        {
            hashCode = HashCode.Combine(hashCode, component);
        }

        return hashCode;
    }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    public bool Equals(T other)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    {
        if (other == null)
        {
            return false;
        }

        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    protected abstract IEnumerable<object> GetEqualityComponents();
}
