using System;

public class NullValue
{
    public static double? GetAverage(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (double? value in values)
        {
            if (value.HasValue)
            {
                sum += value.Value;
                count++;
            }
        }

        if (count == 0)
        {
            return null;
        }

        double average = sum / count;

        return Math.Round(average, 2, MidpointRounding.AwayFromZero);
    }
}
