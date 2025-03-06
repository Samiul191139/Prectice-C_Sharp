using System;

namespace ATMSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(10000);
            atm.Menu();
        }
    }

    class ATM
    {
        private int balance;

        public ATM(int initialBalance)
        {
            balance = initialBalance;
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n===== ATM Menu =====");
                Console.WriteLine("1. Withdraw Money");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        WithdrawMoney();
                        break;
                    case "2":
                        CheckBalance();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using the ATM!");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void WithdrawMoney()
        {
            Console.Write("\nEnter withdrawal amount: ");
            int amount;
            if (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
                return;
            }

            if (amount % 500 != 0)
            {
                Console.WriteLine("Error: Amount must be a multiple of 500.");
                return;
            }

            if (balance - amount < 500)
            {
                Console.WriteLine("Error: Insufficient balance. Minimum balance of 500 must be maintained.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawal successful! You withdrew {amount}. Remaining balance: {balance}");
        }

        private void CheckBalance()
        {
            Console.WriteLine($"\nYour current balance is: {balance}");
        }
    }
}
