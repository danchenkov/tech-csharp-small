using System;

namespace DateTimeFiddling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            int delay;
            do
            {
                Console.WriteLine("Hours from now?");
            } while (!int.TryParse(Console.ReadLine(), out delay));

            Console.WriteLine("In {0} hours it will be {1}", delay, DateTime.Now.AddHours(delay));
        }
    }
}
