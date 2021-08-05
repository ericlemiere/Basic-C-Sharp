using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParameter
{
    class MathOp
    {
        public int Multiply(int value1, int value2 = 1)
        {
            if (value2 == 1)
            {
                value2 = value1;
            }
            return value1 * value2;
        }
    }
}
