using System;
using System.Collections.Generic;

namespace IQuittable
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> things;
        public override void SayName()
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Employee " + FirstName + " " + LastName + " has had enough");
            Console.ReadLine();
        }
        public static bool operator ==(Employee<T> employeeOne, Employee<T> employeeTwo)
        {
            return (employeeOne.FirstName == employeeTwo.FirstName && employeeOne.LastName == employeeTwo.LastName);
        }
        public static bool operator !=(Employee<T> employeeOne, Employee<T> employeeTwo)
        {
            return !(employeeOne == employeeTwo);
            // return (employeeOne.FirstName != employeeTwo.FirstName || employeeOne.LastName != employeeTwo.LastName);
        }
        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var employeeTwo = o as Employee<T>;

            return (FirstName == employeeTwo.FirstName && LastName == employeeTwo.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName + " " + LastName).GetHashCode();
        }
    }
}
