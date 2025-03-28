using System;


namespace lab4
{
    class Employee
    {
        public string Name;
        public int Salary;

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary calculation is based on role.");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary) { }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Manager {Name}'s salary is calculated with bonuses: {Salary}.");
        }
    }

    class Programmer : Employee
    {
        public Programmer(string name, int salary) : base(name, salary) { }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Programmer {Name}'s salary is calculated based on projects: {Salary}.");
        }
    }
}
