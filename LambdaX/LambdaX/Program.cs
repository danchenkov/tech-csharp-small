using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
    }
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee> {};
        employees.Add(new Employee { FirstName = "Alice", LastName = "Adams" });
        employees.Add(new Employee { FirstName = "Bob", LastName = "Brown" });
        employees.Add(new Employee { FirstName = "Charlie", LastName = "Crabbs" });
        employees.Add(new Employee { FirstName = "Dave", LastName = "McCoy" });
        employees.Add(new Employee { FirstName = "Eve", LastName = "Ericsson" });
        employees.Add(new Employee { FirstName = "Frank", LastName = "Honnest" });
        employees.Add(new Employee { FirstName = "Grace", LastName = "Garrison" });
        employees.Add(new Employee { FirstName = "Heidi", LastName = "Hamilton" });
        employees.Add(new Employee { FirstName = "Ivan", LastName = "Ivanoff" });
        employees.Add(new Employee { FirstName = "Joe", LastName = "Jones" });

        List<Employee> selectedEmployees = new List<Employee> { };

        //foreach (Employee employee in employees)
        //{
        //    if (employee.FirstName == "Joe")
        //    {
        //        selectedEmployees.Add(employee);
        //    }
        //}
        selectedEmployees = employees.Where(e => e.FirstName == "Joe").ToList();

        foreach (Employee employee in selectedEmployees)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }
        Console.ReadLine();
    }
}