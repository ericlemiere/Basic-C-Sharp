using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create array of names
            string[] names = new string[] { "Damian", "CJ", "Jusuf", "Derrick", "Norm" };
            Console.WriteLine("Please type your last name:");
            string lastName = Console.ReadLine();

            for (int ii = 0; ii < names.Length; ii++)
            {
                string fullName = names[ii] + " " + lastName;
                names[ii] = fullName;
                Console.WriteLine(names[ii]);
            }

            // Create new list of names
            List<string> mylist = new List<string>() { "Damian", "CJ", "Jusuf", "Derrick", "Norm" };
            Console.WriteLine("\nPlease type in a name to search for in mylist:");
            string searchName = Console.ReadLine();

            for (int ii = 0; ii < mylist.Count; ii++)
            {
                if (searchName == mylist[ii])
                {
                    Console.WriteLine("The name you searched for is in the list at index " + ii);
                    ii = mylist.Count; // set ii to number of elements in list so no more iterations occur
                }
                // when iterations get to last one, if the name doesn't match last element, 
                // then the name is not present
                else if (ii == mylist.Count - 1 && searchName != mylist[ii])
                {
                    Console.WriteLine("I'm sorry. The name you searched for is not in the list.");
                }
            }


            // Create new list of names
            List<string> mylist2 = new List<string>() { "Otto", "Rudy", "Rudy", "Tony", "Beth" };
            Console.WriteLine("\nPlease type in a name to search for in mylist2:");
            string searchName2 = Console.ReadLine();
            int count = 0;

            for (int ii = 0; ii < mylist2.Count; ii++)
            {
                if (searchName2 == mylist2[ii])
                {
                    Console.WriteLine("The name you searched for is in the list at index " + ii);
                    count++;
                }
                // when iterations get to last one, if the name doesn't match last element, 
                // then the name is not present
                else if (ii == mylist2.Count - 1 && count == 0)
                {
                    Console.WriteLine("I'm sorry. The name you searched for is not in the list.");
                }
            }


            // Create new list of names
            Console.WriteLine("\nHere are the names in the namesList:");
            List<string> namesList = new List<string>() { "Otto", "Rudy", "Rudy", "Tony", "Beth", "Beth", "Tony" };
            int nameCount = 1;
            foreach (string name in namesList)
            {
                Console.Write(name);
                // This loop won't run on first time through because nameCount - 1 is zero.
                // Every other time it runs, it runs through the list up to the name printed.
                // When we print the 3rd name
                for (int ii = 0; ii < nameCount - 1; ii++)
                {
                    if (name == namesList[ii]) 
                    {
                        Console.Write(" (This name has already occured in the list)");
                    }
                }
                nameCount++; 
                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
