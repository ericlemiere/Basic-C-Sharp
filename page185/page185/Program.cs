using System;

namespace page185
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            string inputNum = Console.ReadLine();
            float num1 = float.Parse(inputNum);
            Console.WriteLine(num1 % 7);



        }
    }
}
