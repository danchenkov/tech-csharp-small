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
    }
}
