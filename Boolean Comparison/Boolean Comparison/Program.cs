using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bring a brick and measure its weight");

        int totalWeight = 0;
        int weight;
        while (totalWeight < 21)
        {
            Console.WriteLine("Not there yet (need 21). Currently at " + totalWeight + " tons");
            do
            {
                Console.WriteLine("What is the brick's weight?");
            } while (!int.TryParse(Console.ReadLine(), out weight));
            totalWeight += weight;
        }

        Console.WriteLine("Yay! You created a pile of bricks with overall weight of " + totalWeight + " tons");
        Console.Read();
    }
}
