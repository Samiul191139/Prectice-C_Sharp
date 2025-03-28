using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select a program to run:");
        Console.WriteLine("1. Vehicle Class Hierarchy");
        Console.WriteLine("2. Shape Class Hierarchy");
        Console.WriteLine("3. Multilevel Inheritance");
        Console.WriteLine("4. Animal Class Hierarchy");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                RunVehicleProgram();
                break;
            case 2:
                RunShapeProgram();
                break;
            case 3:
                RunInheritanceProgram();
                break;
            case 4:
                RunAnimalProgram();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void RunVehicleProgram()
    {
        Vehicle car = new Car("Toyota", 2022, "Petrol");
        Vehicle truck = new Truck("Ford", 2020, "Diesel");
        Vehicle motorcycle = new Motorcycle("Honda", 2021, "Petrol");

        car.DisplayInfo();
        Console.WriteLine("Fuel Efficiency: " + car.FuelEfficiency() + " km/l");
        Console.WriteLine("Max Speed: " + car.MaxSpeed() + " km/h");
        Console.WriteLine();

        truck.DisplayInfo();
        Console.WriteLine("Fuel Efficiency: " + truck.FuelEfficiency() + " km/l");
        Console.WriteLine("Max Speed: " + truck.MaxSpeed() + " km/h");
        Console.WriteLine();

        motorcycle.DisplayInfo();
        Console.WriteLine("Fuel Efficiency: " + motorcycle.FuelEfficiency() + " km/l");
        Console.WriteLine("Max Speed: " + motorcycle.MaxSpeed() + " km/h");
    }

    static void RunShapeProgram()
    {
        Console.WriteLine("Enter the radius of the circle:");
        int radius = int.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine("Area of the circle: " + circle.CalculateArea());

        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, width);
        Console.WriteLine("Area of the rectangle: " + rectangle.CalculateArea());

        Console.Write("Enter the base length of the triangle: ");
        double baseLength = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        double height = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(baseLength, height);
        Console.WriteLine("Area of the triangle: " + triangle.CalculateArea());

    }

    static void RunInheritanceProgram()
    {
        Child obj = new Child();
        obj.ShowAll();
    }

    static void RunAnimalProgram()
    {
        Dove dove = new Dove();
        dove.Walk();
        dove.Fly();
        dove.ShowColor();
    }
}