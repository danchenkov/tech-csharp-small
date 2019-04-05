using System;

namespace Company
{
    class Person
    {
        public string FirstName; // who cares about getters and setters?
        public string LastName;
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
