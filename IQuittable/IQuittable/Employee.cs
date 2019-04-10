using System;

namespace IQuittable
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Employee " + FirstName + " " + LastName + " has had enough");
            Console.ReadLine();
        }
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return (employeeOne.FirstName == employeeTwo.FirstName && employeeOne.LastName == employeeTwo.LastName);
        }
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            return !(employeeOne == employeeTwo);
            // return (employeeOne.FirstName != employeeTwo.FirstName || employeeOne.LastName != employeeTwo.LastName);
        }
        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var employeeTwo = o as Employee;

            return (FirstName == employeeTwo.FirstName && LastName == employeeTwo.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName + " " + LastName).GetHashCode();
        }
    }
}
