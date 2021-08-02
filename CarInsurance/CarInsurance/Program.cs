using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CAR INSURANCE FINDER");

            Console.WriteLine("\nWhat is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);

            Console.WriteLine("\nHave you ever had a DUI? (yes/no)");
            string dui = Console.ReadLine().ToLower();
            while ((dui != "yes") && (dui != "no"))
            {
                Console.WriteLine("Invalid input. Please type 'yes' or 'no'");
                Console.WriteLine("\nHave you ever had a DUI? (yes/no)");
                dui = Console.ReadLine();
            }

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketNum = Convert.ToInt32(tickets);

            Console.Write("\nQualified? ");
            Console.WriteLine(age > 15 && dui == "no" && ticketNum <= 3);
            Console.Write("\nPress any key to exit. ");
            Console.Read();
        }
    }
}
