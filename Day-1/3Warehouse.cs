// using System;
// class Warehouse
// {
//     public static void Main()
//     {
//         System.Console.WriteLine("Welcome to Warehouse: ");

//         double length;
//         double width;
//         double height;

// System.Console.WriteLine("Enter the length in CM");
//         if(!double.TryParse(Console.ReadLine(),out length))
//         {
//             System.Console.WriteLine("Invalid Lenght Input");
//             return;
//         }
//         if (length <= 0)
//         {
//             System.Console.WriteLine("Length Should not be Negative or ZERO");
//         return;
//         }


// System.Console.WriteLine("Enter the Width in CM");
//         if(!double.TryParse(Console.ReadLine(),out width))
//         {
//             System.Console.WriteLine("Invalid Width Input");
//             return;
//         }
//         if (width <= 0)
//         {
//             System.Console.WriteLine("Width Should not be Negative or ZERO");
//         return;
//         }


// System.Console.WriteLine("Enter the height in CM");
//         if(!double.TryParse(Console.ReadLine(),out height))
//         {
//             System.Console.WriteLine("Invalid Height Input");
//             return;
//         }
//         if (height <= 0)
//         {
//             System.Console.WriteLine("Height Should not be Negative or ZERO");
//         return;
//         }

// double volume=length*width*height;

// System.Console.WriteLine($"Calculated Volume is {volume:F2} Cm3");

//     }
// }