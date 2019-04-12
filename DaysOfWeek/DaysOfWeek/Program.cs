using System;

class Program
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)
    {
        DayOfWeek dow;
        do
        {
            Console.WriteLine("Day of Week?");
        } while (!DayOfWeek.TryParse(Console.ReadLine(), out dow));

        Console.WriteLine("You are right, " + dow + " is a day of week");
        Console.ReadLine();
    }
}