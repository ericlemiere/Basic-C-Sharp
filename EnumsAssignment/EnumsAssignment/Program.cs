using System;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {            
                Console.WriteLine("Please enter the current day of the week: ");
                string dayEntered = Console.ReadLine();
                // Instantiate DayOfWeek object
                // Check user input to see if it is in the enum
                // True ignores case of string
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayEntered, true);
                Console.WriteLine("\nToday is {0}.", day);
            }
            catch 
            {
                Console.WriteLine("\nPlease enter an actual day of the week.");
            }

        }
    }
}
