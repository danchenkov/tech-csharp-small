using System;
using System.Collections.Generic;

namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> josh = new Employee<string>();

            josh.FirstName = "Josh";
            josh.LastName = "Smith";
            josh.things = new List<string>() { "hammer", "nail", "oil", "alcohol" };
            josh.Quit();

            foreach (string thing in josh.things)
            {
                Console.WriteLine(thing);
            }

            Employee<int> bill = new Employee<int>();
            bill.FirstName = "Bill";
            bill.LastName = "Jones";
            bill.things = new List<int>() { 1, 2, 3, 4 };
            foreach (int thing in bill.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
