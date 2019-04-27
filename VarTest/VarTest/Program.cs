using System;

namespace VarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld);

            var helloMoon = "Hello Moon!";
            Console.WriteLine(helloMoon);

            var math = new MathOperations(2.12);
            Console.WriteLine("Lets pretend this is random " + math.NewRandom());
            Console.WriteLine("Lets pretend this is random " + math.NewRandom());
            Console.WriteLine("Lets pretend this is random " + math.NewRandom());

            Console.ReadLine();
        }
    }
}
