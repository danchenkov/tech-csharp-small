using System;

//What course are you on?

//What page number?

//Do you need help with anything? Please answer “true” or “false”.

//Were there any positive experiences you’d like to share? Please give specifics.

//Is there any other feedback you’d like to provide? Please be specific.

//How many hours did you study today?

//After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly.Have a great day!” This would be the end of the program.

class Program {
    static void Main(string[] args) {
        string course;
        int pageNumber= 0;
        bool helpNeeded;
        string experiences;
        string feedback;
        int studyHoursToday = 0;


        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What course are you on?");
        course = Console.ReadLine();

        do {
            Console.WriteLine("What page number?");
        } while (!Int32.TryParse(Console.ReadLine(), out pageNumber));


        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        switch (Console.ReadLine().ToLower()) {
            case "y":
            case "yes":
            case "true":
                helpNeeded = true;
                break;
            default:
                helpNeeded = false;
                break;
        }

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        experiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        feedback = Console.ReadLine();

        do {
            Console.WriteLine("How many hours did you study today?");
        } while (!Int32.TryParse(Console.ReadLine(), out studyHoursToday));

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        Console.Read();
    }
}
