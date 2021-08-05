using System;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp multiply = new MathOp();
            Console.WriteLine("\nNow you will enter two new values to multiply together:");
            Console.WriteLine("Value 1:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value 2: (Press enter to skip. Output will be the first value squared.)");

            try
            {
                string value2Str = Console.ReadLine();
                if (value2Str != "")
                {
                    int value2 = Convert.ToInt32(value2Str);
                    Console.WriteLine("{0} * {1} = {2}", value1, value2, multiply.Multiply(value1, value2));
                }
                else
                {
                    Console.WriteLine("{0}^2 = {1}", value1, multiply.Multiply(value1));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input Error");
            }
        }
    }
}
