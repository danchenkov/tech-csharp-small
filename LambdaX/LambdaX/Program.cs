using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    struct Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
    }
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee> {};
        employees.Add(new Employee { Id = 0, FirstName = "Alice", LastName = "Adams" });
        employees.Add(new Employee { Id = 1, FirstName = "Bob", LastName = "Brown" });
        employees.Add(new Employee { Id = 2, FirstName = "Charlie", LastName = "Crabbs" });
        employees.Add(new Employee { Id = 3, FirstName = "Dave", LastName = "McCoy" });
        employees.Add(new Employee { Id = 4, FirstName = "Eve", LastName = "Ericsson" });
        employees.Add(new Employee { Id = 5, FirstName = "Frank", LastName = "Honnest" });
        employees.Add(new Employee { Id = 6, FirstName = "Grace", LastName = "Garrison" });
        employees.Add(new Employee { Id = 7, FirstName = "Heidi", LastName = "Hamilton" });
        employees.Add(new Employee { Id = 8, FirstName = "Ivan", LastName = "Ivanoff" });
        employees.Add(new Employee { Id = 9, FirstName = "Joe", LastName = "Jones" });

        List<Employee> selectedEmployees = new List<Employee> { };

        foreach (Employee employee in employees)
        {
            if (employee.FirstName == "Joe")
            {
                selectedEmployees.Add(employee);
            }
        }

        selectedEmployees = employees.Where(e => e.FirstName == "Joe").ToList();
        foreach (Employee employee in selectedEmployees)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }

        Console.WriteLine("-------------------------");

        selectedEmployees = employees.Where(e => e.Id > 5).ToList();
        foreach (Employee employee in selectedEmployees)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }

        Console.ReadLine();
    }
}