using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareClass square = new SquareClass();

            Console.WriteLine("\nEnter an integer you would like squared: ");
            int squareInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0}^2 = {1}", squareInt, square.Square(squareInt));

            Console.WriteLine("\nEnter a decimal you would like squared: ");
            decimal squareDec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n{0}^2 = {1}", squareDec, square.Square(squareDec));

            Console.WriteLine("\nEnter a number you would like squared: ");
            string squareStr = Console.ReadLine();
            Console.WriteLine("\n{0}^2 = {1}", squareStr, square.Square(squareStr));

        }
    }
}
