using System;

namespace Exceptional
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int guessYear;
            bool guessAgain = true;
            
            while(guessAgain)
            {
                Console.WriteLine("What is your age? (in years, use digits only)");
                string ageString = Console.ReadLine();
                guessAgain = false;
                try
                {
                    int age = Int32.Parse(ageString);
                    if (age <= 0) { throw new NegativeAgeException(); }
                    guessYear = now.AddYears(-age).Year;

                    Console.WriteLine("You must have been born in {0} or {1}", guessYear - 1, guessYear);
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad Format: {0}", ageString);
                    guessAgain = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow Error: {0}", ageString);
                    guessAgain = true;
                }
                catch (NegativeAgeException)
                {
                    Console.WriteLine("It is unlikely that you have that age: {0}", ageString);
                    guessAgain = true;
                }
            }


        }
    }
}
