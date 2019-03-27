using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("Person 1");
        Int32 person1HourlyRate;
        do
        {
            Console.WriteLine("Hourly Rate?");
        } while (!Int32.TryParse(Console.ReadLine(), out person1HourlyRate));
        Int32 person1WorkedPerWeek;
        do
        {
            Console.WriteLine("Hours worked per week?");
        } while (!Int32.TryParse(Console.ReadLine(), out person1WorkedPerWeek));

        Console.WriteLine("Person 2");
        Int32 person2HourlyRate;
        do
        {
            Console.WriteLine("Hourly Rate?"); // or "rate" - assignment is ambigious
        } while (!Int32.TryParse(Console.ReadLine(), out person2HourlyRate));
        Int32 person2WorkedPerWeek;
        do
        {
            Console.WriteLine("Hours worked per week?");
        } while (!Int32.TryParse(Console.ReadLine(), out person2WorkedPerWeek));

        Console.WriteLine("Weekly salary of Person 1");
        Int32 person1Salary = person1HourlyRate * person1WorkedPerWeek;
        Console.WriteLine(person1Salary);

        Console.WriteLine("Weekly salary of Person 2");
        Int32 person2Salary = person2HourlyRate * person2WorkedPerWeek;
        Console.WriteLine(person2Salary);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(person1Salary > person2Salary);

        Console.Read();
    }
}
