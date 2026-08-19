using System;

public abstract class Employee
{
    public abstract decimal CalculatePay();
}

public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal CalculatePay()
    {
        return rate * hours;
    }
}

public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public override decimal CalculatePay()
    {
        return monthlySalary;
    }
}

public class CommissionEmployee : Employee
{
    private decimal baseSalary;
    private decimal commission;

    public CommissionEmployee(decimal baseSalary, decimal commission)
    {
        this.baseSalary = baseSalary;
        this.commission = commission;
    }

    public override decimal CalculatePay()
    {
        return baseSalary + commission;
    }
}

public class InheritAndPoly
{
    public static decimal CalculateTotalPay(string[] employees)
    {
        decimal totalPay = 0;

        foreach (string employee in employees)
        {
            string[] parts = employee.Split(' ');

            Employee emp;

            if (parts[0] == "H")
            {
                decimal rate = decimal.Parse(parts[1]);
                decimal hours = decimal.Parse(parts[2]);

                emp = new HourlyEmployee(rate, hours);
            }
            else if (parts[0] == "S")
            {
                decimal salary = decimal.Parse(parts[1]);

                emp = new SalariedEmployee(salary);
            }
            else
            {
                decimal baseSalary = decimal.Parse(parts[1]);
                decimal commission = decimal.Parse(parts[2]);

                emp = new CommissionEmployee(baseSalary, commission);
            }

            totalPay += emp.CalculatePay();
        }

        return Math.Round(totalPay, 2);
    }
}
