using System;

public class PositiveSumm
{
    public static int SumPositiveUntilZero(int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                break;
            }

            if (num < 0)
            {
                continue;
            }

            sum += num;
        }

        return sum;
    }
}
