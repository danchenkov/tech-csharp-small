using System;

class Program
{
    static void Main(string[] args)
    {
        Variadic v = new Variadic();

        int numberOne;
        do
        {
            Console.WriteLine("Number One?");
        } while (!Int32.TryParse(Console.ReadLine(), out numberOne));

        int numberTwo;
        Console.WriteLine("Number Two (optional)?");
        Int32.TryParse(Console.ReadLine(), out numberTwo);

        Console.WriteLine(v.MathOperation(numberOne, numberTwo));

        Console.WriteLine("_____________________________");
        do
        {
            Console.WriteLine("Number One?");
        } while (!Int32.TryParse(Console.ReadLine(), out numberOne));

        Console.WriteLine("Number Two (optional)?");
        Int32.TryParse(Console.ReadLine(), out numberTwo);

        Console.WriteLine(v.MathOperation(numberOne, numberTwo));

        Console.WriteLine("_____________________________");
        do
        {
            Console.WriteLine("Number One?");
        } while (!Int32.TryParse(Console.ReadLine(), out numberOne));

        Console.WriteLine("Number Two (optional, will ignore)?");
        Int32.TryParse(Console.ReadLine(), out numberTwo);

        Console.WriteLine(v.MathOperation(numberOne));

        Console.ReadLine();
    }
}
