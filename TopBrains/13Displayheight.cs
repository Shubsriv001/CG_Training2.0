using System;
using System.Security.Cryptography.X509Certificates;

public class Height
{
    public string Height_Check(int heightCm)
    {
        if (heightCm < 150)
        {
            return "Short";
        }
        else if (heightCm < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }

        public static void Main()
    {
       Height obj=new Height();
     System.Console.WriteLine(obj.Height_Check(176)); 
    }
}