using System;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            do
            {
                Console.WriteLine("What is your age?");
            } while (!int.TryParse(Console.ReadLine(), out age));

            File.WriteAllText("C:\\Users\\IEUser\\Code\\logs\\test-log.txt", "User with age " + age);
            Console.Write("Your age " + age + " has been logged to a file");
        }
    }
}
