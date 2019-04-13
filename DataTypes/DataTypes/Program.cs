using System;

class Program
{
    struct Number
    {
        public decimal Amount;
    }
    static void Main(string[] args)
    {
        Number number = new Number();
        number.Amount = 3.14159265358979323M;

        Console.WriteLine(number.Amount);
        Console.ReadLine();
    }
}
