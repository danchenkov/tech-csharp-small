using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresso
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            do
            {
                Console.WriteLine("Enter a number to perform operations on");
            } while (!int.TryParse(Console.ReadLine(), out value1));

            Console.WriteLine("Original value " + value1);
            value1 = MathOperations.Increment(value1);
            Console.WriteLine("Incremented value " + value1);

            value1 = MathOperations.Double(value1);
            Console.WriteLine("Doubled value " + value1);

            value1 = MathOperations.Decrement(value1);
            Console.WriteLine("Decremented value " + value1);

            Console.ReadLine();

        }
    }
}
