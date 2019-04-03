using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listOne = new List<int> {32, 16, 8, 4 };

        int divisor;
        do
        {
            Console.WriteLine("Enter a number to divide the list numbers by");
        } while (!Int32.TryParse(Console.ReadLine(), out divisor));
        
        Console.WriteLine("Divided list:");
        try
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                Console.WriteLine(listOne[i] / divisor);
            }
        }
        
        catch (DivideByZeroException e) 
        {
            Console.WriteLine("Can't really divide by zero, here is an ideal of a result");
            for (int i = 0; i < listOne.Count; i++)
            {
                Console.WriteLine("∞");
            }
        }
        Console.ReadLine();

    }
}

