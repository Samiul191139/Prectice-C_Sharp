//A company wants to manage different types of employees. There are three types: FullTime, PartTime, and Intern. Each employee has a Name, ID, and method CalculateSalary() which behaves differently based on employee type.

//Requirements:
//Create an enum named EmployeeType with values: FullTime, PartTime, Intern.
//Use an abstract Employee base class with common properties and abstract method CalculateSalary().
//Create derived classes for each employee type, overriding CalculateSalary().
//Create a list of mixed employee types and call CalculateSalary() polymorphically.


namespace prac1_chatgpt
{
    enum EmployeeType
    {
        Fulltime,
        PartTime,
        Intern
    }
    abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public EmployeeType Type { get; set; }
        public Employee(string name, int id, EmployeeType type)
        {
            Name = name;
            Id = id;
            Type = type;
        }
        public abstract void CalculateSalary();
    }

    class Fulltimer : Employee
    {
        public Fulltimer(string name, int id) : base(name, id, EmployeeType.Fulltime) { }
        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} (ID: {Id}) - Full-Time Salary: $5000");
        }
    }

    class Parttimer : Employee
    {
        public Parttimer(string name, int id) : base(name, id, EmployeeType.Fulltime) { }
        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} (ID: {Id}) - Full-Time Salary: $2000");
        }
    }

    class Intern : Employee
    {
        public Intern(string name, int id) : base(name, id, EmployeeType.Fulltime) { }
        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} (ID: {Id}) - Full-Time Salary: $1000");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Fulltimer("Sami", 123),
                new Parttimer("Kh", 124),
                new Intern("a", 125)
            };

            foreach (var employee in employees)
            {
                employee.CalculateSalary();
            }
        }
    }
}
