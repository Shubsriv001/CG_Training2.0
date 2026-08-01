using System;


class Swapping
{

public static void swap(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    public static void Main()
    {
        int a=5;
        int b=10;
        System.Console.WriteLine($"Before swapping a= {a} b= {b}");
        Swapping.swap(ref a, ref b);

        System.Console.WriteLine($"After swapping a= {a} b= {b}");

        
    }
}