// using System;

// class Retail
// {
//     public static void Main()
//     {
//         double price;
//         int Quantity;
//         double discount;

//         System.Console.WriteLine("Enter Item Price: ");

//         if (!Double.TryParse(Console.ReadLine(), out price))
//         {
//             System.Console.WriteLine("Enter valid data");
//             return;
//         }

//         if (price < 0)
//         {
//             System.Console.WriteLine("Price cannot be negative");
//             return;
//         }

//         System.Console.WriteLine("Enter Quantity: ");

//         if (!int.TryParse(Console.ReadLine(), out Quantity))
//         {
//             System.Console.WriteLine("Enter valid data");
//             return;
//         }

//         if (Quantity < 0)
//         {
//             System.Console.WriteLine("Quantity cannot be negative");
//             return;
//         }

//         System.Console.WriteLine("Enter Discount Percent: ");

//         if (!double.TryParse(Console.ReadLine(), out discount))
//         {
//             System.Console.WriteLine("Enter valid data");
//             return;
//         }

//         if (discount < 0)
//         {
//             System.Console.WriteLine("Discount cannot be negative");
//             return;
//         }

//         double SubTotal = Math.Round(price * Quantity);
//         double discountAmount = Math.Round(SubTotal * discount / 100, 2);
//         double payableAmount = Math.Round(SubTotal - discountAmount, 2);

//         System.Console.WriteLine($"SubTotal Amount: {SubTotal}");
//         System.Console.WriteLine($"Discounted Amount: {discountAmount}");
//         System.Console.WriteLine($"Payable Amount: {payableAmount}");
//     }
// }