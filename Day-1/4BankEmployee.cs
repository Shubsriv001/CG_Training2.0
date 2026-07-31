// using System;
// using System.Runtime.ConstrainedExecution;
// class Emplyee
// {
//     public static void Main()
//     {
//         double opening_balance;
//         double total_deposit;
//         double total_withdrawal;

//         System.Console.WriteLine("Ente the Opening Amount:  ");

//     if(!double.TryParse(Console.ReadLine(),out opening_balance))
//         {
//             System.Console.WriteLine("Invalid Amount");
//             return;
//         }
//         if (opening_balance < 0)
//         {
//           System.Console.WriteLine("Amount Should Not be Negative");  
//           return;
//         }

//         System.Console.WriteLine("Enter Total Deposit Amount: ");

//         if(!double.TryParse(Console.ReadLine(),out total_deposit))
//         {
//             System.Console.WriteLine("Invalid deposit Amount");
//             return;
//         }
//         if (total_deposit < 0)
//         {
//           System.Console.WriteLine("Deposit amount Should Not be Negative");
//           return;  
//         }

//         System.Console.WriteLine("Enter Total Withdrawal Amount:");

//         if(!double.TryParse(Console.ReadLine(),out total_withdrawal))
//         {
//             System.Console.WriteLine("Invalid Withdrawal Amount");
//             return;
//         }
//         if (total_withdrawal < 0)
//         {
//           System.Console.WriteLine("Withdrawal amount Should Not be Negative");  
//           return;
//         }

//         double total=opening_balance+total_deposit;

//         if (total < total_withdrawal)
//         {
//             System.Console.WriteLine($"you have only {total} and withdrawing {total_withdrawal} shame on You bro...");
//         }

//         else
//         {
//             total-=total_withdrawal;
//             System.Console.WriteLine($"You Withdraw {total_withdrawal}");
//             System.Console.WriteLine($"Amount Left {total}");

//         }
//     }
// }