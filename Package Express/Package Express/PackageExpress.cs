using System;

class PackageExpress
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        int weight;
        do
        {
            Console.WriteLine("Please enter the package weight:");
        } while (!int.TryParse(Console.ReadLine(), out weight));

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.Read();
            return;
        }

        int width;
        do
        {
            Console.WriteLine("Please enter the package width:");
        } while (!int.TryParse(Console.ReadLine(), out width));

        int height;
        do
        {
            Console.WriteLine("Please enter the package height:");
        } while (!int.TryParse(Console.ReadLine(), out height));

        int length;
        do
        {
            Console.WriteLine("Please enter the package length:");
        } while (!int.TryParse(Console.ReadLine(), out length));

        if ( width + length + height > 50) {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.Read();
            return;
        }

        Console.WriteLine("Your estimated total for shipping this package is: $" + (width + length + height) * weight / 100.0);
        Console.WriteLine("Thank you.");
        Console.Read();
    }
}
