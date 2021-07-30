using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);

            // if the student answers yes, then the needHelp variable will be 
            // set to true and can be used later to generate different responses
            Console.WriteLine("\nDo you need help with anything? Please answer “true” or “false.”");
            string helpMe = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(helpMe);
            Console.WriteLine(helpNeeded);

            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string studyHours = Console.ReadLine();
            int hours = Convert.ToInt32(studyHours);

            // Output a message with user input included
            Console.WriteLine("\nWe are glad to see you put in " + studyHours + " hours of work on " + course + " today, and that you made it all the way to page " + pageNum + "!");

            Console.WriteLine("\nAn Instructor will respond to this shortly. Thanks and have a great day, " + name + "!");

            Console.Read();
        }
    }
}
