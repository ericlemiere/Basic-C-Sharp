using System;

namespace p285assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathOp = new MathOp();

            Console.WriteLine("Please enter an integer:");
            int value = Convert.ToInt32(Console.ReadLine());

            mathOp.DivideByTwo(value);




        }
    }
}
