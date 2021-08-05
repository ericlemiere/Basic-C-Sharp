using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    class SquareClass
    {
        public int Calc(int value)
        {
            return value * 3;
        }

        public int Calc(decimal value)
        {
            return Convert.ToInt32(value * 9);
        }

        public int Calc(string value)
        {
            int valueNum = Convert.ToInt32(value);
            return valueNum * valueNum;
        }
    }
}
