using System;

public class Programming
{
    static int SumOfDigits(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }

        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsLucky(int num)
    {
        if (IsPrime(num))
        {
            return false;
        }

        int digitSum = SumOfDigits(num);
        int squareDigitSum = SumOfDigits(num * num);

        return squareDigitSum == digitSum * digitSum;
    }

    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (IsLucky(i))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
