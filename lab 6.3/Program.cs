using System;
interface IVehicle
{
    void StartEngine();
    void StopEngine();
    double CalculateFuelEfficiency();
}
abstract class Vehicle : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }

    public abstract double CalculateFuelEfficiency();
}
class Car : Vehicle
{
    public override double CalculateFuelEfficiency()
    {
        Console.WriteLine("Calculating Car fuel efficiency...");
        return 15.5;
    }
}
class Truck : Vehicle
{
    public override double CalculateFuelEfficiency()
    {
        Console.WriteLine("Calculating Truck fuel efficiency...");
        return 8.0;
    }

    public void LoadCargo()
    {
        Console.WriteLine("Cargo loaded into the truck.");
    }
}


class TransportSystem
{
    static void Main()
    {
        IVehicle myCar = new Car();
        Console.WriteLine("Car:");
        myCar.StartEngine();
        Console.WriteLine($"Fuel Efficiency: {myCar.CalculateFuelEfficiency()} km/l");
        myCar.StopEngine();

        Console.WriteLine();

        Truck myTruck = new Truck();
        Console.WriteLine("Truck:");
        myTruck.StartEngine();
        Console.WriteLine($"Fuel Efficiency: {myTruck.CalculateFuelEfficiency()} km/l");
        myTruck.LoadCargo();
        myTruck.StopEngine();
    }
}
