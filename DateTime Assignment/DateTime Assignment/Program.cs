using System;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is {0}", DateTime.Now);
            Console.WriteLine("\nPlease enter a number: ");
            double userNum = Convert.ToDouble(Console.ReadLine());

            // Show user what the date and time will be in the number of hours input
            Console.WriteLine("\nIn {0} hour(s), the time will be {1}", userNum, DateTime.Now.AddHours(userNum));

        }
    }
}
