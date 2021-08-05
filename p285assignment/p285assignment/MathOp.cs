using System;
using System.Collections.Generic;
using System.Text;

namespace p285assignment
{
    class MathOp
    {
        public static string thankYouMsg;
        public static string halved;

        static MathOp()
        {
            thankYouMsg = "Thank you for using my program.";
            halved = "You successfully halved your integer.";
        }

        // Method takes integer parameter
        public void DivideByTwo(int value)
        {
            // Divide input value by 2
            Console.WriteLine("{0} divided by 2 is {1}", value, value / 2);
            // Call static class
            Console.WriteLine(MathOp.halved);
        }

        // Method takes string parameter
        public void DivideByTwo(string value)
        {
            Console.WriteLine("{0} divided by 2 is {1}", value, (Convert.ToInt32(value) / 2));
            Console.WriteLine(MathOp.halved);
        }

        public void Operations(int value, out int xAdd, out int xSub, out int xMult, out int xDiv)
        {
            xAdd = value + 2;
            xSub = value - 2;
            xMult = value * 2;
            xDiv = value / 2;
        }
    }
}
