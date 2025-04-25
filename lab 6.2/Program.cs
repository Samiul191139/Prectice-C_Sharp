using System;


class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }
        else if (amount > Balance)
        {
            throw new InsufficientFundsException("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. Remaining balance: {Balance}");
        }
    }
}
class SimpleBankingApp
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount(1000);

        Console.WriteLine("Welcome to Simple Bank!");
        Console.WriteLine($"Your current balance is: {myAccount.Balance}");

        try
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            myAccount.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
