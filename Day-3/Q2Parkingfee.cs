using System;

class ParkingFee
{
    public void CalculateFee()
    {
        char typeOfVehicle;
        double totalHours;
        double totalFee = 0;

        Console.WriteLine("Enter Vehicle Type (C-Car, M-Motorcycle, T-Truck)");

        if (!char.TryParse(Console.ReadLine(), out typeOfVehicle))
        {
            Console.WriteLine("Invalid Vehicle Type");
            return;
        }

        typeOfVehicle = char.ToUpper(typeOfVehicle);


        Console.WriteLine("Enter Parking Duration in Hours");

        if (!double.TryParse(Console.ReadLine(), out totalHours))
        {
            Console.WriteLine("Invalid Parking Duration");
            return;
        }


        if (totalHours <= 0)
        {
            Console.WriteLine("Invalid Parking Duration");
            return;
        }


        if (totalHours <= 0.5)
        {
            totalFee = 0;
        }
        else
        {
            double payableHours = totalHours - 0.5;


            if (typeOfVehicle == 'C')
            {
                totalFee = payableHours * 3;

                if (totalFee > 25)
                {
                    totalFee = 25;
                }

                Console.WriteLine("Vehicle Type: Car");
            }
            else if (typeOfVehicle == 'M')
            {
                totalFee = payableHours * 2;

                if (totalFee > 15)
                {
                    totalFee = 15;
                }

                Console.WriteLine("Vehicle Type: Motorcycle");
            }
            else if (typeOfVehicle == 'T')
            {
                totalFee = payableHours * 5;

                if (totalFee > 40)
                {
                    totalFee = 40;
                }

                Console.WriteLine("Vehicle Type: Truck");
            }
            else
            {
                Console.WriteLine("Invalid Vehicle Type");
                return;
            }


            if (totalHours > 8)
            {
                totalFee = totalFee - (totalFee * 0.10);
            }
        }


        Console.WriteLine("----------------------");
        Console.WriteLine("Parking Duration: " + totalHours + " hours");
        Console.WriteLine("Discount Applied: " + (totalHours > 8 ? "10%" : "No"));
        Console.WriteLine("Total Parking Fee: $" + totalFee);
    }


    public static void Main()
    {
        ParkingFee parking = new ParkingFee();
        parking.CalculateFee();
    }
}