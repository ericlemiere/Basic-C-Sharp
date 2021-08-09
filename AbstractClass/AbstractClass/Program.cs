using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new employee and print name to console.
            Employee<string> employee1 = new Employee<string>() { employeeNum = 1, FirstName = "Sarah", LastName = "Connor" };
            Employee<string> employee2 = new Employee<string>() { employeeNum = 2, FirstName = "John", LastName = "Daily" };
            Employee<string> employee3 = new Employee<string>() { employeeNum = 1, FirstName = "Quinn", LastName = "Jackson" };
            // Print employee information
            employee1.SayName();
            employee2.SayName();
            employee3.SayName();


            // Insantiate empty Employee objects of different types
            Employee<string> employeeStr = new Employee<string>();
            Employee<int> employeeInt = new Employee<int>();

            // Fill above objects' "things" lists with appropriate types
            employeeStr.things = new List<string>() { "key card", "calculator", "laptop", "mug", "water bottle" };
            employeeInt.things = new List<int>() { 100, 50, 25, 10 };


            Console.Write("\nEach new employee is issued the following: ");
            int ii = employeeStr.things.Count;
            // Loop through lists and print to console
            foreach (string thing in employeeStr.things)
            {
                Console.Write(thing);
                if (ii > 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("\n\n");
                }
                ii--;
            }

            foreach (int thing in employeeInt.things)
            {
                Console.WriteLine(thing);
            }



            if (employee1 == employee2)
            {
                Console.WriteLine("\nOops. These employees have the same ID number.");
            }
            if (employee1 == employee3)
            {
                string fullName1 = employee1.FirstName + " " + employee1.LastName;
                string fullName3 = employee3.FirstName + " " + employee3.LastName;
                Console.WriteLine("\n{0} and {1} have the same ID number.", fullName1, fullName3);
            }

            IQuittable quittable = new Employee<string>();
            quittable.Quit();
             
        }
    }
}
