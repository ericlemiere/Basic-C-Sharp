using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareClass square = new SquareClass();

            Console.WriteLine("\nEnter an integer you would like multiplied by 3: ");
            int valueInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0}*3 = {1}", valueInt, square.Calc(valueInt));

            Console.WriteLine("\nEnter a decimal you would like multiplied by 9: ");
            decimal valueDec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n{0}*9 = {1}", valueDec, square.Calc(valueDec));

            Console.WriteLine("\nEnter a number you would like squared: ");
            string squareStr = Console.ReadLine();
            Console.WriteLine("\n{0}^2 = {1}", squareStr, square.Calc(squareStr));

            //MathOp multiply = new MathOp();
            //Console.WriteLine("\nNow you will enter two new values to multiply together:");
            //Console.WriteLine("Value 1:");
            //int value1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Value 2: (Press enter to skip. Output will be the first value squared.)");

            //try
            //{
            //    string value2Str = Console.ReadLine();
            //    if (value2Str != "")
            //    {
            //        int value2 = Convert.ToInt32(value2Str);
            //        Console.WriteLine("{0} * {1} = {2}", value1, value2, multiply.Multiply(value1, value2));
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}^2 = {1}", value1, multiply.Multiply(value1));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Input Error");
            //}

            


        }
    }
}
