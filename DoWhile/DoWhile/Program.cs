using System;
using System.Text;

namespace DoWhile
{
    class Program
    {
        static void Main()
        {
            int ii = 1;
            // Output value of ii and increment until 10
            while (ii <= 10)
            {
                Console.WriteLine(ii);
                ii++;
            }

            // Decrement value of ii and output value until zero
            do
            {
                ii--;
                Console.WriteLine(ii);
            }
            while (ii >= 1);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello.");
            sb.Append(" My name is Guy.");

            Console.WriteLine(sb);

        }
    }
}
