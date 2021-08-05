using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod
{
    class MathOp
    {
        public void MathMethod(int value1, int value2)
        {
            // Perform the square operation on the first value
            Console.WriteLine("\nThe first value {0} squared is {1}", value1, value1 * value1);
            // Output the second value
            Console.WriteLine("\nThe second value is {0}", value2);
        }
    }
}
