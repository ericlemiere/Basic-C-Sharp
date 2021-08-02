using System;

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


            
        }
    }
}
