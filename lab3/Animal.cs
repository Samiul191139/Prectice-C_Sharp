using System;

class Animal
{
    public void Walk()
    {
        Console.WriteLine("This animal is walking.");
    }

    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }
}

class Dog : Animal
{
    public int NoOfLegs { get; set; }
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

class Bird : Animal
{
    public int NoOfWings { get; set; }
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

class Dove : Bird
{
    public string Color { get; set; }
    public void ShowColor()
    {
        Console.WriteLine("The dove's color is " + Color + ".");
    }
}

