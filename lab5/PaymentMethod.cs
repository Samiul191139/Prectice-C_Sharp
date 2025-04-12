using System;

interface PaymentMethod
{
    void Pay(double amount);
}

class CreditCardPayment : PaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

class PayPalPayment : PaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

class BankTransferPayment : PaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Bank Transfer.");
    }
}

class PaymentProcessor
{
    public void Process(PaymentMethod method, double amount)
    {
        method.Pay(amount);
    }
}
