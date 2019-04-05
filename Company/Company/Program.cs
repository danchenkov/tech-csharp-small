using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { FirstName = "Joe", LastName = "Holsinger" };
            employeeOne.SayName();

            Console.ReadLine();
        }
    }
}
