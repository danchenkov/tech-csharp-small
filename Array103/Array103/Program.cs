using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //1. Create a one-dimensional Array of strings.
        //   Ask the user to input some text.
        //   Create a loop that goes through each string in the Array, adding the user’s text to the string.
        string[] array1 = { "alpha", "bravo" };

        Console.WriteLine("Enter a suffix string");
        string array1Supplement = Console.ReadLine();

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = array1[i] + array1Supplement;
        }
        //   Then create a loop that prints off each string in the Array on a separate line.
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine();

        //2.Create an infinite loop.
        //for (;true;) { }
        //3.Fix the infinite loop so it will execute.
        for (;false;) { }

        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine();

        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        for (int i = 0; i <= array1.Length-1; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine();

        //6.Create a List of strings where each item in the list is unique. 
        //  Ask the user to select text to search for in the List.
        //  Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        List<string> list2 = new List<string> { "alpha", "bravo", "charlie", "delta", "echo", "foxtrot", "golf", "hotel", "india", "juliet", "kilo", "lima" };

        //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
        Console.WriteLine("Enter a word to guess an item in the list");
        string list2Query = Console.ReadLine();
        bool list2Check = false;

        for (int i = 0; i <= list2.Count-1; i++)
        {
            if (list2Query == list2[i])
            {
                list2Check = true;
                //8.Add code to that above loop that stops it from executing once a match has been found.
                break;
            }
        }

        if (list2Check)
        {
            Console.WriteLine("The text you entered is in the list");
        }
        else
        {
            Console.WriteLine("The text you entered is not in the list");
        }
        Console.WriteLine();


        //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
        //  Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
        List<string> list3 = new List<string> { "alpha", "bravo", "charlie", "delta", "echo", "foxtrot", "golf", "hotel", "india", "echo", "juliet", "kilo", "lima" };
        Console.WriteLine("Enter a word to find its position in the list");
        string list3Query = Console.ReadLine();
        bool list3Check = false;
        for (int i = 0; i < list3.Count; i++)
        {
            if (list3Query == list3[i])
            {
                Console.WriteLine(i);
                list3Check = true;
            }
        }
        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
        if (!list3Check)
        {
            Console.WriteLine("The text you entered is not in the list");
        }
        Console.WriteLine();

        //11.Create a List of strings that has at least two identical strings in the List.
        //   Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        List<string> list4 = new List<string> { "alpha", "bravo", "charlie", "delta", "echo", "foxtrot", "echo", "golf", "hotel", "india", "juliet", "kilo", "lima", "lima" };
        int idx = 0;
        foreach ( string check in list4 )
        {
            if (idx != list4.IndexOf(check)) {
                Console.WriteLine(check + ": has already appeared in the list before");
            }
            else
            {
                Console.WriteLine(check + ": has not appeared in the list before");
            }
            idx++;
        }
        Console.ReadLine();
    }
}