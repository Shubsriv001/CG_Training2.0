using System;

public class Arithmatic
{
    public static string ArithmaticExpression (string expression)
    {
        string[] arr = expression.Split(' ');

        if (arr.Length != 3)
            return "Error:InvalidExpression";

        int a, b;

        if (!int.TryParse(arr[0], out a) || !int.TryParse(arr[2], out b))
            return "Error:InvalidNumber";

        if (arr[1] == "+")
            return (a + b).ToString();

        else if (arr[1] == "-")
            return (a - b).ToString();

        else if (arr[1] == "*")
            return (a * b).ToString();

        else if (arr[1] == "/")
        {
            if (b == 0)
                return "Error:DivideByZero";

            return (a / b).ToString();
        }

        else
            return "Error:UnknownOperator";
    }

    public static void Main()
    {
        System.Console.WriteLine("Enter the expression to calcuate int the form of a op b");
        string exp=Console.ReadLine();
        
       System.Console.WriteLine(Arithmatic.ArithmaticExpression(exp));
    }
}