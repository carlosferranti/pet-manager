namespace Anima.Inscricao.Domain._Shared.Extensions;

public static class IEnumerableExtensions
{
    public static int? MaxValue<T>(this IEnumerable<T> source, Func<T, int> selector)
    {
        using var enumerator = source.GetEnumerator();
        if (!enumerator.MoveNext()) return null;

        int maxValue = selector(enumerator.Current);

        while (enumerator.MoveNext())
        {
            int value = selector(enumerator.Current);
            if (value > maxValue)
            {
                maxValue = value;
            }
        }
        return maxValue;
    }
}
