using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] codeStrings = { "alpha", "bravo", "charlie", "delta", "echo", "foxtrot" };
        int[] years = { 1980, 1982, 1990, 1991, 2000, 2006 };
        List<string> listStrings = new List<string> { "alpha", "bravo", "charlie", "delta", "echo", "foxtrot" };

        int indexCodeStrings;
        do
        {
            Console.WriteLine("Enter Code String index:");
        } while (!int.TryParse(Console.ReadLine(), out indexCodeStrings) || (indexCodeStrings < 0) || (indexCodeStrings >= codeStrings.Length));
        Console.WriteLine(codeStrings[indexCodeStrings]);

        int indexYears;
        do
        {
            Console.WriteLine("Enter Year index:");
        } while (!int.TryParse(Console.ReadLine(), out indexYears) || (indexYears < 0) || (indexYears >= years.Length));
        Console.WriteLine(years[indexYears]);

        int indexListStrings;
        do
        {
            Console.WriteLine("Enter Code String (List) index:");
        } while (!int.TryParse(Console.ReadLine(), out indexListStrings) || (indexListStrings < 0) || (indexListStrings >= listStrings.Count));
        Console.WriteLine(listStrings[indexListStrings]);

        Console.ReadLine();
    }
}