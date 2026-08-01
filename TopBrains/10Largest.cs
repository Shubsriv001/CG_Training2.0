using System;

public class Largest
{
    public static int Find_Largest(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;

        else if (b >= a && b >= c)
            return b;

        else
            return c;
    }

    public static void Main()
    {
        int a = 10;
        int b = 25;
        int c = 15;

        int largest = Largest.Find_Largest(a, b, c);

        Console.WriteLine("Largest number is: " + largest);
    }
}