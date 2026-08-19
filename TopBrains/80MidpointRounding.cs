using System;

public class Midpoint
{
    public static double CalculateArea(double radius)
    {
        double area = Math.PI * radius * radius;

        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
}
