using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider divide = new Divider();

            Int32 halfme;
            do
            {
                Console.WriteLine("Number?");
            } while (!Int32.TryParse(Console.ReadLine(), out halfme));

            Console.WriteLine(divide.half(halfme));

            Console.WriteLine("______________________________");

            Int32 halfmetoo;
            do
            {
                Console.WriteLine("Number?");
            } while (!Int32.TryParse(Console.ReadLine(), out halfmetoo));

            divide.half(halfmetoo, out int result);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
