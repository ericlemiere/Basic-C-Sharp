using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading
{
    class SquareClass
    {
        public int Square(int value)
        {
            return value * value;
        }

        public int Square(decimal value)
        {
            return Convert.ToInt32(value * value);
        }

        public int Square(string value)
        {
            int valueNum = Convert.ToInt32(value);
            return valueNum * valueNum;
        }
    }
}
