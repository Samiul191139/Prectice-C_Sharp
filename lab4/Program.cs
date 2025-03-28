using System;

namespace lab4
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Employee Salary Calculation:");
            Employee manager = new Manager("Alice", 45000);
            Employee programmer = new Programmer("Bob", 5000);
            manager.CalculateSalary();
            programmer.CalculateSalary();

            Console.WriteLine("\nAnimal Sounds:");
            Animal dog = new Dog();
            Animal cow = new Cow();
            Animal cat = new Cat();
            dog.Speak();
            cow.Speak();
            cat.Speak();
        }
    }
}
