using System;

class Multiply
{
    public static void mul(int digit, int number){
        
        int []arr=new int [number];
    for(int i=1; i<=number; i++)
        {
            arr[i-1]=digit*i;
        }

        foreach(int i in arr)
        {
            System.Console.WriteLine(i);
        }
    }

public static void Main()
    {
       Multiply.mul(3,5);
    }

}