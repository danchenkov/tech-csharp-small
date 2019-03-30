using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bring a brick and measure its weight");

        int totalWeight = 0;
        int weight;
        while (totalWeight < 100)
        {
            do
            {
                Console.WriteLine("What is the brick's weight?");
            } while (!int.TryParse(Console.ReadLine(), out weight));
            totalWeight += weight;

            Console.WriteLine("Not there yet. Currently at " + totalWeight + " tons");
        }

        Console.WriteLine("Yay! You created a pile of bricks with overall weight of " + totalWeight + " tons");
        Console.Read();
    }
}

