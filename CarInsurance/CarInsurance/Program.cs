using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CAR INSURANCE FINDER");

            // Get age and convert input to int
            Console.WriteLine("\nWhat is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);

            // See if driver has had a DUI
            Console.WriteLine("\nHave you ever had a DUI? (yes/no)");
            string dui = Console.ReadLine().ToLower();
            while ((dui != "yes") && (dui != "no")) // Check for valid input
            {
                Console.WriteLine("Invalid input. Please type 'yes' or 'no'");
                Console.WriteLine("\nHave you ever had a DUI? (yes/no)");
                dui = Console.ReadLine();
            }

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketNum = Convert.ToInt32(tickets);

            // Output whether or not driver is qualified
            // Must be over age of 15, no DUIs, and no more than 3 tickets
            Console.Write("\nQualified? ");
            Console.WriteLine(age > 15 && dui == "no" && ticketNum <= 3);
            Console.Write("\nPress any key to exit. ");
            Console.Read();
        }
    }
}
