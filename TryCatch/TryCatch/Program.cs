using System;
using System.Collections.Generic;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 10, 20, 100 };

            try
            {
                Console.WriteLine("Please input an integer to divide by:");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                foreach (int num in myList)
                {
                    Console.WriteLine(num / divideBy);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You did not provide an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }



        }
    }
}
