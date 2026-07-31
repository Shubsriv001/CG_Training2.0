using System;


class Employee
{
    public string name;
    public double totalworkhours;

}


class PayrollCalculate : Employee
{
   public double OvertimePay;
    public double RegularPay;
   public double hourlyRate;
    
}
class Payroll
{
    public static void Main()
    {

        PayrollCalculate obj=new PayrollCalculate();


        System.Console.WriteLine("Enter the name of the Employee");
        
        obj.name=Console.ReadLine();
        if (obj.name == "")
        {
            System.Console.WriteLine("Invalid Input");
            return;
        }

        System.Console.WriteLine("Enter the total work hours");
        if(!double.TryParse(Console.ReadLine(),out obj.totalworkhours))
        {
            System.Console.WriteLine("Enter the valid overtime");
            return;
        }
        if (obj.totalworkhours < 0)
        {
            System.Console.WriteLine("Overtime should not be Negative");
            return;
        }
        System.Console.WriteLine("Enter hourly rates");
        if(!double.TryParse(Console.ReadLine(), out obj.hourlyRate))
        {
            System.Console.WriteLine("Enter the valid Hourly rate");
            return;
        }
        if (obj.hourlyRate < 0)
        {
            System.Console.WriteLine("Hourly rate must be Positive");
            return;
        }
        
       


        obj.RegularPay=210*obj.hourlyRate;

        obj.OvertimePay=(obj.totalworkhours-210)*obj.hourlyRate;

        
        System.Console.WriteLine($"Employee name: {obj.name}\nRegular Salary: {obj.RegularPay}\nOverTime pay: {obj.OvertimePay}\nOverAll Salary: {obj.RegularPay+obj.OvertimePay}");
        
       

        

    }
}