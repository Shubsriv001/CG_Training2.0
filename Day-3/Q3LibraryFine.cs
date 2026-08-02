using System;

class LibraryFine
{
    public void CalculateFine()
    {
        char itemType;
        char userType;
        int lateDays;
        double fineAmount = 0;


        Console.WriteLine("Enter Item Type (B-Book, D-DVD, J-Journal)");

        if (!char.TryParse(Console.ReadLine(), out itemType))
        {
            Console.WriteLine("Invalid Item Type");
            return;
        }

        itemType = char.ToUpper(itemType);


        Console.WriteLine("Enter Number of Days Late");

        if (!int.TryParse(Console.ReadLine(), out lateDays))
        {
            Console.WriteLine("Invalid Days");
            return;
        }


        Console.WriteLine("Enter User Type (S-Student, R-Regular)");

        if (!char.TryParse(Console.ReadLine(), out userType))
        {
            Console.WriteLine("Invalid User Type");
            return;
        }

        userType = char.ToUpper(userType);


        if (lateDays <= 3)
        {
            fineAmount = 0;
        }
        else
        {
            int chargeableDays = lateDays - 3;


            if (itemType == 'B')
            {
                fineAmount = chargeableDays * 0.50;

                Console.WriteLine("Item Type: Book");
            }
            else if (itemType == 'D')
            {
                fineAmount = chargeableDays * 1.00;

                Console.WriteLine("Item Type: DVD");
            }
            else if (itemType == 'J')
            {
                fineAmount = chargeableDays * 0.25;

                Console.WriteLine("Item Type: Journal");
            }
            else
            {
                Console.WriteLine("Invalid Item Type");
                return;
            }


            if (fineAmount > 20)
            {
                fineAmount = 20;
            }


            if (userType == 'S')
            {
                fineAmount = fineAmount - (fineAmount * 0.50);
            }
            else if (userType != 'R')
            {
                Console.WriteLine("Invalid User Type");
                return;
            }
        }


        Console.WriteLine("----------------------");
        Console.WriteLine("Days Late: " + lateDays);
        Console.WriteLine("User Type: " + userType);
        Console.WriteLine("Calculated Fine Amount: $" + fineAmount);
    }


    public static void Main()
    {
        LibraryFine library = new LibraryFine();
        library.CalculateFine();
    }
}