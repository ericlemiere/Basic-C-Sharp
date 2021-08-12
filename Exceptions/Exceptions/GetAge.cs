using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class GetAge
    {
        public int GetUserAge()
        {
            int age = 0;
            bool validAge = false;

            while (!validAge)
            {
                Console.WriteLine("What is your age?");
                validAge = int.TryParse(Console.ReadLine(), out age);
                if (!validAge)
                {
                    throw new ArgumentException();
                }
                if (age < 0) throw new NegativeException();
            }
            return age;
        }

        public void YearOfBirth(int age)
        {
            // Check if user age is zero
            if (age == 0) Console.WriteLine("Wow! You were born this year and you are already using a computer!");
            else
            {
                DateTime year = DateTime.Now.AddYears(-age);
                Console.WriteLine("You were born {0} years ago in the year {1}.", age, year.Year);
            }
        }
    }
}
