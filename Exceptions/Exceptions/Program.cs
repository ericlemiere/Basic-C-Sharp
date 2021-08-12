using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAge getAge = new GetAge();
            try
            {
                int age = getAge.GetUserAge(); // Call the method GetUserAge
                getAge.YearOfBirth(age); // Call method to show Year of Birth
            }
            catch (ArgumentException) // This catches if anything other than an integer was input
            {
                Console.WriteLine("Incorrect input. Program ended.");
            }
            catch (NegativeException) // This catches if the user inputs a negative number
            {
                Console.WriteLine("Your age cannot be negative. Program ended.");
            }
            catch (Exception) // Catches general exceptions
            {
                Console.WriteLine("Error. Program ended.");
            }
        }
    }
}
