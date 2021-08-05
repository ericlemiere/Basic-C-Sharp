using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //SquareClass square = new SquareClass();

            //Console.WriteLine("\nEnter an integer you would like squared: ");
            //int squareInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n{0}^2 = {1}", squareInt, square.Square(squareInt));

            //Console.WriteLine("\nEnter a decimal you would like squared: ");
            //decimal squareDec = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("\n{0}^2 = {1}", squareDec, square.Square(squareDec));

            //Console.WriteLine("\nEnter a number you would like squared: ");
            //string squareStr = Console.ReadLine();
            //Console.WriteLine("\n{0}^2 = {1}", squareStr, square.Square(squareStr));

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
