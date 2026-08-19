using System;

public class SortedArray
{
    public static T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
    {
        T[] merged = new T[a.Length + b.Length];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k] = a[i];
                i++;
            }
            else
            {
                merged[k] = b[j];
                j++;
            }

            k++;
        }

        while (i < a.Length)
        {
            merged[k] = a[i];
            i++;
            k++;
        }

        while (j < b.Length)
        {
            merged[k] = b[j];
            j++;
            k++;
        }

        return merged;
    }
}
