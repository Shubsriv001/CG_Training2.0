using System;

public class Parsing
{
    public static int SumValidIntegers(string[] tokens)
    {
        int sum = 0;

        foreach (string token in tokens)
        {
            int number;

            if (int.TryParse(token, out number))
            {
                sum += number;
            }
        }

        return sum;
    }
}
