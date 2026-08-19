using System;

public interface IArea
{
    double GetArea();
}

public abstract class Shape : IArea
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

public class Triangle : Shape
{
    private double b;
    private double h;

    public Triangle(double b, double h)
    {
        this.b = b;
        this.h = h;
    }

    public override double GetArea()
    {
        return 0.5 * b * h;
    }
}

public class Strings
{
    public static double CalculateTotalArea(string[] shapes)
    {
        double totalArea = 0;

        foreach (string shape in shapes)
        {
            string[] parts = shape.Split(' ');

            if (parts[0] == "C")
            {
                double r = double.Parse(parts[1]);
                Circle circle = new Circle(r);
                totalArea += circle.GetArea();
            }
            else if (parts[0] == "R")
            {
                double w = double.Parse(parts[1]);
                double h = double.Parse(parts[2]);

                Rectangle rectangle = new Rectangle(w, h);
                totalArea += rectangle.GetArea();
            }
            else if (parts[0] == "T")
            {
                double b = double.Parse(parts[1]);
                double h = double.Parse(parts[2]);

                Triangle triangle = new Triangle(b, h);
                totalArea += triangle.GetArea();
            }
        }

        return Math.Round(totalArea, 2, MidpointRounding.AwayFromZero);
    }
}
