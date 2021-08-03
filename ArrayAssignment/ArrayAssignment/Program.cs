using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            // Create string array, fill it with strings, and ask user for an int
            string[] strArray = new string[] { "Eric", "Amber", "Helo", "Harvard" };
            Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
            int selection1 = Convert.ToInt32(Console.ReadLine());
            // if int is outside of range, as for new int input
            while (selection1 < 0 || selection1 > 3 )
            {
                Console.WriteLine("Index out of range.");
                Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
                selection1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The name in the array at that index is:");
            Console.WriteLine(strArray[selection1]);

            // Create int array, fill it with ints, and ask user for an int
            int[] intArray = new int[] { 12, 44, 0, 77 };
            Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
            int selection2 = Convert.ToInt32(Console.ReadLine());
            while (selection2 < 0 || selection2 > 3)
            {
                Console.WriteLine("Index out of range.");
                Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
                selection2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The name in the array at that index is:");
            Console.WriteLine(intArray[selection2]);


            // Create new list of strings
            List<string> mylist = new List<string>();
            mylist.Add("Index 0");
            mylist.Add("Index 1");
            mylist.Add("Index 2");
            mylist.Add("Index 3");
            Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
            int selection3 = Convert.ToInt32(Console.ReadLine());
            while (selection3 < 0 || selection3 > 3)
            {
                Console.WriteLine("Index out of range.");
                Console.WriteLine("Please select a number from 0 to 3. [0,1,2,3]");
                selection3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mylist[selection3]);


            Console.ReadLine();
        }
    }
}
