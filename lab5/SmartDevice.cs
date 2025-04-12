using System;

interface SmartDevice
{
    void TurnOn();
    void TurnOff();
}

class Light : SmartDevice
{
    public void TurnOn() => Console.WriteLine("Light is ON.");
    public void TurnOff() => Console.WriteLine("Light is OFF.");
}

class Fan : SmartDevice
{
    public void TurnOn() => Console.WriteLine("Fan is ON.");
    public void TurnOff() => Console.WriteLine("Fan is OFF.");
}

class AC : SmartDevice
{
    public void TurnOn() => Console.WriteLine("AC is ON.");
    public void TurnOff() => Console.WriteLine("AC is OFF.");
}

class SmartHomeController
{
    public void Control(SmartDevice device)
    {
        device.TurnOn();
        device.TurnOff();
    }
}
