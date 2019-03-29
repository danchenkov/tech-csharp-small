using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Car Insurance");

        int age;
        do
        {
            Console.WriteLine("What is your age?");
        } while (!int.TryParse(Console.ReadLine(), out age));

        Console.WriteLine("Have you ever had a DUI?");
        bool hadDUI = true;
        switch (Console.ReadLine()) {
            case "NO":
            case "No":
            case "no":
            case "Nope":
            case "nope":
            case "N":
            case "n":
                hadDUI = false;
                break;
        }

        int speedingTickets;
        do
        {
            Console.WriteLine("How many speeding tickets to you have?");
        } while (!int.TryParse(Console.ReadLine(), out speedingTickets));

        Console.WriteLine("Qualified?");
        Console.WriteLine(age > 15 && !hadDUI && speedingTickets <= 3);

        Console.Read();
    }
}
