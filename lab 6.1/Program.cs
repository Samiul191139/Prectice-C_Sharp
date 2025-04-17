using System;
namespace lab_6
{
    class SimpleCalculator
    {
        static void Main()
        {
            Console.WriteLine("Simple Division Calculator");

            while (true)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    double result = DivideNumbers(num1, num2);
                    Console.WriteLine("Result: " + result);
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero.\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong.\n");
                }
            }
        }

        static double DivideNumbers(double a, double b)
        {
            return a / b;
        }
    }

}
