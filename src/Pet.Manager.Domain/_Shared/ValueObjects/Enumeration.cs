using System.Reflection;

namespace Anima.Inscricao.Domain._Shared.ValueObjects;

public abstract class Enumeration : IComparable
{
    protected Enumeration(int id, string name) => (Id, Name) = (id, name);

    public string Name { get; private set; }

    public int Id { get; private set; }

    public static IEnumerable<T> GetAll<T>()
        where T : Enumeration =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
                 .Select(f => f.GetValue(null))
                 .Cast<T>();

    public override string ToString() => Name;

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
    public override bool Equals(object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = Id.Equals(otherValue.Id);

        return typeMatches && valueMatches;
    }

    public int CompareTo(object obj) => Id.CompareTo(((Enumeration)obj).Id);

    // Other utility methods ...
}
