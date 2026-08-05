using System;
using System.Collections.Generic;

class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Price_Per_Day { get; set; }
}

class BikeUtility
{
    private SortedDictionary<int, Bike> bike_details = new SortedDictionary<int, Bike>();

    public void AddBike(string model, string brand, int price)
    {
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            Price_Per_Day = price
        };

        int id = bike_details.Count + 1;
        bike_details.Add(id, bike);
    }

    public void DisplayBikeByBrand()
    {
        SortedDictionary<string, List<Bike>> groupData = new SortedDictionary<string, List<Bike>>();

        foreach (var item in bike_details)
        {
            if (!groupData.ContainsKey(item.Value.Brand))
            {
                groupData[item.Value.Brand] = new List<Bike>();
            }

            groupData[item.Value.Brand].Add(item.Value);
        }

        foreach (var brand in groupData)
        {
            Console.WriteLine("Brand : " + brand.Key);

            foreach (var bike in brand.Value)
            {
                Console.WriteLine("Model : " + bike.Model);
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        BikeUtility obj = new BikeUtility();

        bool run = true;

        while (run)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Add Bike Details");
            System.Console.WriteLine("Group Bikes By Brand");
            System.Console.WriteLine("Exit");

            System.Console.WriteLine("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        System.Console.WriteLine("Please Enter the Model of the Bike");
                        string bike_model = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(bike_model))
                        {
                            System.Console.WriteLine("Invalid model data");
                            return;
                        }
                        System.Console.WriteLine("Please Enter the Brand of the Bike");

                        string bike_brand = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(bike_brand))
                        {
                            System.Console.WriteLine("Invalid brand data");
                            return;
                        }

                        System.Console.WriteLine("Please Enter the Price Per Day of the Bike");
                        int bike_price_perday = Convert.ToInt32(Console.ReadLine());

                        if (bike_price_perday <= 0)
                        {
                            System.Console.WriteLine("Price should be Greater than 0 and positive");
                            return;
                        }

                        obj.AddBike(bike_model, bike_brand, bike_price_perday);
                        break;
                    }

                case 2:
                    {

                        obj.DisplayBikeByBrand();
                        break;
                    }

                case 3:
                    {

                        run = false;
                        System.Console.WriteLine("You are out from selection process");
                        return;
                    }

                default:
                    {
                        System.Console.WriteLine("Invalid Selection");
                        break;
                    }


            }
        }



    }
}