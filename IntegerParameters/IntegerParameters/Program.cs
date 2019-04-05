using System;

class Program
{
    static void Main(string[] args)
    {
        Handle handle = new Handle();
        handle.Process(1, 2);
        Console.WriteLine(handle.total);

        handle.Process(a: 2, b: 7);
        Console.WriteLine(handle.total);

        Console.ReadLine();
    }
}