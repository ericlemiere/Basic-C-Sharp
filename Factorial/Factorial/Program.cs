using System;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = 4;
            Console.WriteLine(Factorial(userNum));

            int[] arr1 = new int[] { 5, 9, 0 };
            int[] arr2 = new int[] { 1, 4, 8, 7 };

            Console.WriteLine(canNest(arr1, arr2));
        }

        public static int Factorial(int num)
        {
            int fact = num;
            if (num == 0) return 1;
            for (int i = num-1; i > 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static bool canNest(int[] arr1, int[] arr2)
        {
            if (arr1.Min() > arr2.Min() || arr1.Max() < arr2.Max()) return true;
            else return false;
        }
    }
}
