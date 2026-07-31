// using System;
// class Fitness
// {
//     public static void Main()
//     {
//         System.Console.WriteLine("Welcome to BMI CalCulator:-");

//         double weight;
//         double Height;
//         System.Console.WriteLine("Enter the Weight in Kgs");

//         if(!double.TryParse(Console.ReadLine(),out weight))
//         {
//             System.Console.WriteLine("Invalid Input");
//             return;
//         }

//         if (weight <= 0)
//         {
//             System.Console.WriteLine("weight not be Negative Or ZERO");
//             return;
//         }

//         System.Console.WriteLine("Enter the Height in Meters");

//         if(!double.TryParse(Console.ReadLine(),out Height))
//         {
//             System.Console.WriteLine("Invalid Input");
//             return;
//         }

//         if (Height <= 0)
//         {
//             System.Console.WriteLine("Height not be Negative Or ZERO");
//             return;
//         }

//          double BMI=weight/(Height*Height);

//         System.Console.WriteLine($"BMI= {BMI}");

//         if (BMI < 18.5)
//         {
//             System.Console.WriteLine("UnderWeight");
            
//         }
//          if(BMI>=18.5 && BMI <= 24.9)
//         {
//             System.Console.WriteLine("Normal (Healthy  Weight)");
//         }
//         else if(BMI>=25.0 && BMI <= 29.9)
//         {
//             System.Console.WriteLine("Overweight");
//         }
//         else if(BMI>=30.0 && BMI <= 34.9)
//         {
//             System.Console.WriteLine("Obesity class I");
//         }
//         else if(BMI>=35.0 && BMI <= 39.9)
//         {
//             System.Console.WriteLine("Obesity class II");
//         }
//         else if(BMI>=40.0)
//         {
//         System.Console.WriteLine("Obesity class III (Severe/Morbid obesity)");

//         }
//     }
// }