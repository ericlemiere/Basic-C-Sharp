using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOp mathOp = new MathOp();
           
            // Pass two integers to the class
            mathOp.MathMethod(7, 20);

            int value1 = 22;
            int value2 = 23;
            // Pass two values by name to the class
            mathOp.MathMethod(value1, value2);
        }
    }
}
