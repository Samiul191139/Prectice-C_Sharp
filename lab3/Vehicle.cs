class Vehicle
{
    public string Model;
    public int Year;
    public string FuelType;

    public Vehicle(string model, int year, string fuelType)
    {
        Model = model;
        Year = year;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Year: {Year}, Fuel: {FuelType}");
    }

    public virtual double FuelEfficiency()
    {
        return 0;
    }

    public virtual double MaxSpeed()
    {
        return 0;
    }
}

class Car : Vehicle
{
    public Car(string model, int year, string fuelType) : base(model, year, fuelType) { }

    public override double FuelEfficiency()
    {
        return 15;
    }

    public override double MaxSpeed()
    {
        return 180;
    }
}

class Truck : Vehicle
{
    public Truck(string model, int year, string fuelType) : base(model, year, fuelType) { }

    public override double FuelEfficiency()
    {
        return 8;
    }

    public override double MaxSpeed()
    {
        return 120;
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string model, int year, string fuelType) : base(model, year, fuelType) { }

    public override double FuelEfficiency()
    {
        return 40;
    }

    public override double MaxSpeed()
    {
        return 220;
    }
}