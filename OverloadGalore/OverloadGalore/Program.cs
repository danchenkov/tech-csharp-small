using System;

class Program
{
    static void Main(string[] args)
    {
        Confusion confusion = new Confusion();
        int result = confusion.GuessWhat(12);
        Console.WriteLine(result);

        result = confusion.GuessWhat((decimal)12.2);
        Console.WriteLine(result);

        result = confusion.GuessWhat("13");
        Console.WriteLine(result);

        Console.ReadLine();
    }
}
