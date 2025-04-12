using System;
using System.Collections.Generic;

interface Payable
{
    double CalculatePay();
}

class FullTimeEmployee : Payable
{
    private double salary;

    public FullTimeEmployee(double salary)
    {
        this.salary = salary;
    }

    public double CalculatePay()
    {
        return salary;
    }
}

class PartTimeEmployee : Payable
{
    private double hourlyRate;
    private int hoursWorked;

    public PartTimeEmployee(double rate, int hours)
    {
        hourlyRate = rate;
        hoursWorked = hours;
    }

    public double CalculatePay()
    {
        return hourlyRate * hoursWorked;
    }
}

class Contractor : Payable
{
    private double projectPay;

    public Contractor(double pay)
    {
        projectPay = pay;
    }

    public double CalculatePay()
    {
        return projectPay;
    }
}

class PayrollSystem
{
    public void Process(List<Payable> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"Payment: ${emp.CalculatePay()}");
        }
    }
}
