// using System;
// using System.IO.Compression;

// public class Cutomer
// {
//     public string customerType;
//     public string name;
//     public double unitsUsed;
//     public double rate;
// }

// public interface calculateBill
// {
//     public double calculate(Cutomer cutomer);
// }

// public class ElectricBilling : calculateBill
// {
//     public double calculate(Cutomer cutomer)
//     {
//         Console.WriteLine("Enter the customer type Residential/Commercial");
//         cutomer.customerType = Console.ReadLine();

//         Console.WriteLine("Enter Units Used");
//         while (!double.TryParse(Console.ReadLine(), out cutomer.unitsUsed))
//         {
//             Console.WriteLine("Invalid Units. Enter Again:");
//         }

//         Console.WriteLine("Enter Rate");
//         while (!double.TryParse(Console.ReadLine(), out cutomer.rate))
//         {
//             Console.WriteLine("Invalid Rate. Enter Again:");
//         }

//         double bill = 0.0;

//         if (cutomer.customerType.ToLower() == "residential")
//         {
//             bill = cutomer.unitsUsed * cutomer.rate;
//         }
//         else if (cutomer.customerType.ToLower() == "commercial")
//         {
//             bill = cutomer.unitsUsed * cutomer.rate;
//         }
//         else
//         {
//             Console.WriteLine("Invalid Customer Type");
//         }

//         return bill;
//     }
// }

// class Billing
// {
//     public static void Main()
//     {
//         Console.WriteLine("Welcome to Billing Calculator");

//         Cutomer obj = new Cutomer();

//         Console.WriteLine("Enter the name of the customer");
//         obj.name = Console.ReadLine();

//         ElectricBilling elobj = new ElectricBilling();

//         double bill = elobj.calculate(obj);

//         Console.WriteLine("Customer Name : " + obj.name);
//         Console.WriteLine("Customer Type : " + obj.customerType);
//         Console.WriteLine("Total Bill : " + bill);
//     }
// }