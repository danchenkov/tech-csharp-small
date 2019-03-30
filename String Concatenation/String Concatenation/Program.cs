using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string headline = "Future bestseller";
        string part1 = "Beginning paragraph";
        string part2 = "Deck";
        string part3 = "This is the main body of the article and the footer";
        StringBuilder story = new StringBuilder();

        Console.WriteLine(headline.ToUpper());
        Console.WriteLine(part1 + "\n" + part2 + "\n" + part3);

        story.Append(headline.ToUpper() + "\n" + part1 + "\n" + part2 + "\n" + part3);
        Console.WriteLine();
        Console.WriteLine(story);

        Console.Read();
    }
}