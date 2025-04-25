using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
}

class Department
{
    public List<Employee> Employees { get; set; } = new List<Employee>();

    public void ShowEmployees()
    {
        foreach (var emp in Employees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Position: {emp.Position}");
        }
    }

    static void Main()
    {
        Department dept = new Department();
        dept.Employees.Add(new Employee { Id = 1, Name = "Sami", Position = "Manager" });
        dept.Employees.Add(new Employee { Id = 2, Name = "Siam", Position = "Developer" });

        dept.ShowEmployees();
    }
}
