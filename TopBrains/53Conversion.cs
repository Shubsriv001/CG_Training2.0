using System;

public class Conversion
{
    public static double FeetToCentimeters(int feet)
    {
        double centimeters = feet * 30.48;

        return Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);
    }
}
