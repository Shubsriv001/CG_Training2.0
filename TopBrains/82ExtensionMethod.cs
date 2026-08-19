using System;
using System.Collections.Generic;

public static class Extensions
{
    public static IEnumerable<T> DistinctBy<T, TKey>(
        this IEnumerable<T> items,
        Func<T, TKey> keySelector)
    {
        HashSet<TKey> seen = new HashSet<TKey>();

        foreach (T item in items)
        {
            if (seen.Add(keySelector(item)))
            {
                yield return item;
            }
        }
    }
}

public class ExtensionMethod

{
    public static string[] GetDistinctNames(string[] items)
    {
        return items
            .DistinctBy(item => item.Split(':')[0])
            .Select(item => item.Split(':')[1])
            .ToArray();
    }
}
