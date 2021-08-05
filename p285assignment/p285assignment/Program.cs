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

            Console.WriteLine("Please enter another integer:");
            string valueStr = Console.ReadLine();
            mathOp.DivideByTwo(valueStr);

            Console.WriteLine("\nPlease enter an integer to perform various operations to:");
            int x = Convert.ToInt32(Console.ReadLine());
            // Declare variables
            int xAdd = 0, xSub = 0, xMult = 0, xDiv = 0;
            // Call Operations method and assign new values to above variables using the out paramaters
            mathOp.Operations(x, out xAdd, out xSub, out xMult, out xDiv);
            Console.WriteLine("{0} + 2 = {1}", x, xAdd);
            Console.WriteLine("{0} - 2 = {1}", x, xSub);
            Console.WriteLine("{0} * 2 = {1}", x, xMult);
            Console.WriteLine("{0} / 2 = {1}", x, xDiv);


            // Calling the static class again just to show it can be called here as well
            Console.WriteLine(MathOp.thankYouMsg);



        }
    }
}
