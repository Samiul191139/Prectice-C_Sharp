using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. E-Commerce Payment");
        Console.WriteLine("2. Smart Home Control");
        Console.WriteLine("3. Payroll System");
        Console.Write("Choose an option to run: ");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("\n--- E-Commerce Payment ---");

            CreditCardPayment creditCard = new CreditCardPayment();
            creditCard.Pay(150);

            PayPalPayment paypal = new PayPalPayment();
            paypal.Pay(75.5);

            BankTransferPayment bank = new BankTransferPayment();
            bank.Pay(300);
        }
        else if (option == 2)
        {
            Console.WriteLine("\n--- Smart Home Control ---");

            Light light = new Light();
            light.TurnOn();
            light.TurnOff();

            Fan fan = new Fan();
            fan.TurnOn();
            fan.TurnOff();

            AC ac = new AC();
            ac.TurnOn();
            ac.TurnOff();
        }
        else if (option == 3)
        {
            Console.WriteLine("\n--- Payroll System ---");

            FullTimeEmployee fullTime = new FullTimeEmployee(5000);
            Console.WriteLine("Full-Time Employee Pay: " + fullTime.CalculatePay());

            PartTimeEmployee partTime = new PartTimeEmployee(20, 80);
            Console.WriteLine("Part-Time Employee Pay: " + partTime.CalculatePay());

            Contractor contractor = new Contractor(1200);
            Console.WriteLine("Contractor Pay: " + contractor.CalculatePay());
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}
