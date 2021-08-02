using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            // Check if package is more than 50. If it is, exit program.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                // Check if package is too large for Package Express.
                // If it is, exit program
                if (height + width + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                // Calculate shipping cost
                else
                {
                    int cost = ((height * width * length) * weight) / 100;
                    string costStr = Convert.ToString(cost);
                    Console.WriteLine("Your estimated cost of shipping is: $" + costStr + ".00");
                }
            }

        }
    }
}
