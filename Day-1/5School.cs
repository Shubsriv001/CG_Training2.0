// using System;

// class School
// {
//     public static void Main()
//     {
        
//     System.Console.WriteLine("Welcome To School Administration");

//     double m1;
//     double m2;
//     double m3;
//     double m4;
//     double m5;

//     System.Console.WriteLine("Enter Marks Marks1");
//     if(!double.TryParse(Console.ReadLine(), out m1))
//         {
//            System.Console.WriteLine("Invalid Mark");
//            return; 
//         }

//         if (m1 < 0)
//         {
//             System.Console.WriteLine("Marks Should not be negative");
//             return;
//         }

//     System.Console.WriteLine("Enter Marks Marks2");
//     if(!double.TryParse(Console.ReadLine(), out m2))
//         {
//            System.Console.WriteLine("Invalid Mark");
//            return; 
//         }

//         if (m2 < 0)
//         {
//             System.Console.WriteLine("Marks Should not be negative");
//             return;
//         }
//     System.Console.WriteLine("Enter Marks Marks3");
//     if(!double.TryParse(Console.ReadLine(), out m3))
//         {
//            System.Console.WriteLine("Invalid Mark");
//            return; 
//         }

//         if (m3 < 0)
//         {
//             System.Console.WriteLine("Marks Should not be negative");
//             return;
//         }
//     System.Console.WriteLine("Enter Marks Marks4");
//     if(!double.TryParse(Console.ReadLine(), out m4))
//         {
//            System.Console.WriteLine("Invalid Mark");
//            return; 
//         }

//         if (m4 < 0)
//         {
//             System.Console.WriteLine("Marks Should not be negative");
//             return;
//         }
//     System.Console.WriteLine("Enter Marks Marks5");
//     if(!double.TryParse(Console.ReadLine(), out m5))
//         {
//            System.Console.WriteLine("Invalid Mark");
//            return; 
//         }

//         if (m5 < 0)
//         {
//             System.Console.WriteLine("Marks Should not be negative");
//             return;
//         }



//         double total=m1+m2+m3+m4+m5;
//         double percentage=Math.Round(total/5,2);

//         System.Console.WriteLine($"Total Marks Obtain {total}");
//         System.Console.WriteLine($"Percentage Obtain {percentage}");

//     }
// }