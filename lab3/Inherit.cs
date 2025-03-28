using System;
class Inherit
{
    public string str = "Inherit class";
    public void InheritMethod()
    {
        Console.WriteLine("Inherit method: " + str);
    }
}

class InheritChild : Inherit
{
    public void InheritChildMethod()
    {
        Console.WriteLine("InheritChild method called. Accessing parent class variable: " + str);
    }
}

class Child : InheritChild
{
    public void ShowAll()
    {
        Console.WriteLine("Child method called. Accessing all parent class properties:");
        InheritMethod();
        InheritChildMethod();
    }
}

