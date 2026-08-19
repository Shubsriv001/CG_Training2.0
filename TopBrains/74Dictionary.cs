using System;
using System.Collections.Generic;

public class Dict
{
    public static decimal GetTotalSalary(
        Dictionary<int, decimal> salaries,
        List<int> employeeIds)
    {
        decimal total = 0;

        foreach (int id in employeeIds)
        {
            if (salaries.ContainsKey(id))
            {
                total += salaries[id];
            }
        }

        return total;
    }
}
