using System;

class Program
{
    static void Main(string[] args)
    {
        Int64 multiply;
        do
        {
            Console.WriteLine("Enter a value to be multiplied by 50");
        } while (!Int64.TryParse(Console.ReadLine(), out multiply));
        Console.WriteLine(multiply + " * 50 = " + (multiply * 50).ToString());

        Int64 sum;
        do
        {
            Console.WriteLine("Enter a value to be added 25 to");
        } while (!Int64.TryParse(Console.ReadLine(), out sum));
        Console.WriteLine(sum + " + 25 = " + (sum + 25).ToString());

        double fraction;
        do
        {
            Console.WriteLine("Enter a value to be divided by 12.5");
        } while (!Double.TryParse(Console.ReadLine(), out fraction));
        Console.WriteLine(fraction + " / 12.5 = " + (fraction / 12.5).ToString());

        Int64 checkNumber;
        do
        {
            Console.WriteLine("Enter a value to be compared with 50");
        } while (!Int64.TryParse(Console.ReadLine(), out checkNumber));
        Console.WriteLine(checkNumber + " > 50 ? " + (checkNumber > 50));

        Int64 checkMyReminder;
        do
        {
            Console.WriteLine("Enter a value to be divided by 7 with the reminder");
        } while (!Int64.TryParse(Console.ReadLine(), out checkMyReminder));
        Console.WriteLine("Reminder of " + checkMyReminder + " / 7 = " + (checkMyReminder % 7).ToString());

        Console.Read();
    }
}
