using System;

public class ObjectArray
{
    public static int SumIntegers(object[] values)
    {
        int sum = 0;

        foreach (object value in values)
        {
            if (value is int x)
            {
                sum += x;
            }
        }

        return sum;
    }
}
