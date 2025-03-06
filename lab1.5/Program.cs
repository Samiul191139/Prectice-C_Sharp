using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the shape type (circle, square, rectangle): ");
            string shapeType = Console.ReadLine().ToLower();

            if (shapeType == "circle")
            {
                Console.Write("Enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("Area of the circle: " + area);
            }
            else if (shapeType == "square")
            {
                Console.Write("Enter the side length: ");
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine("Area of the square: " + area);
            }
            else if (shapeType == "rectangle")
            {
                Console.Write("Enter the length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width: ");
                double width = double.Parse(Console.ReadLine());
                double area = length * width;
                Console.WriteLine("Area of the rectangle: " + area);
            }
            else
            {
                Console.WriteLine("Invalid shape type!");
            }
        }
    }
}
