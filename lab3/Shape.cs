using System;
public class Shape
{
    public int r;

    public virtual double CalculateArea()
    {
        return 0;
    }

}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        return 3.1416 * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length, width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}


public class Triangle : Shape
{
    private double baseLength, height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }
}
