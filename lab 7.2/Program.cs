using System;

delegate double CalculateCircleArea(double radius);
class CircleCalculator
{
    public static double GetArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        CalculateCircleArea areaDelegate = GetArea;
        double area = areaDelegate(7);
        Console.WriteLine("Area of circle is: " + area);
    }
}
