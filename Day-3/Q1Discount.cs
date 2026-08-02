using System;

class Discount
{
    public void DiscountCalculator()
    {
        char customerType;
        double purchaseAmount;
        double discount = 0;

        Console.WriteLine("Enter Customer Type (R-Regular, P-Premium, V-VIP)");

        if (!char.TryParse(Console.ReadLine(), out customerType))
        {
            Console.WriteLine("Invalid Customer Type");
            return;
        }

        customerType = char.ToUpper(customerType);


        Console.WriteLine("Enter Purchase Amount");

        if (!double.TryParse(Console.ReadLine(), out purchaseAmount))
        {
            Console.WriteLine("Invalid Purchase Amount");
            return;
        }


        if (customerType == 'R')
        {
            if (purchaseAmount > 100)
            {
                discount = purchaseAmount * 0.05;
            }
            else
            {
                discount = 0;
            }

            Console.WriteLine("Customer Type: Regular");
        }
        else if (customerType == 'P')
        {
            discount = purchaseAmount * 0.10;

            Console.WriteLine("Customer Type: Premium");
        }
        else if (customerType == 'V')
        {
            if (purchaseAmount > 200)
            {
                discount = purchaseAmount * 0.20;
            }
            else
            {
                discount = purchaseAmount * 0.15;
            }

            Console.WriteLine("Customer Type: VIP");
        }
        else
        {
            Console.WriteLine("Invalid Customer Type");
            return;
        }


        double discountedAmount = purchaseAmount - discount;


        Console.WriteLine("----------------------");
        Console.WriteLine("Purchase Amount: " + purchaseAmount);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Amount: " + discountedAmount);
    }


    public static void Main()
    {
        Discount obj = new Discount();
        obj.DiscountCalculator();
    }
}