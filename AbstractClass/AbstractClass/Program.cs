using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new employees
            Employee<string> employee1 = new Employee<string>() { employeeNum = 1, FirstName = "Sarah", LastName = "Connor" };
            Employee<string> employee2 = new Employee<string>() { employeeNum = 2, FirstName = "John", LastName = "Daily" };
            Employee<string> employee3 = new Employee<string>() { employeeNum = 3, FirstName = "Quinn", LastName = "Jackson" };
            Employee<string> employee4 = new Employee<string>() { employeeNum = 4, FirstName = "Joe", LastName = "Ingles" };
            Employee<string> employee5 = new Employee<string>() { employeeNum = 5, FirstName = "Shaunea", LastName = "Brown" };
            Employee<string> employee6 = new Employee<string>() { employeeNum = 6, FirstName = "Taylor", LastName = "Jenkins" };
            Employee<string> employee7 = new Employee<string>() { employeeNum = 7, FirstName = "Joe", LastName = "Paul" };
            Employee<string> employee8 = new Employee<string>() { employeeNum = 8, FirstName = "Sierra", LastName = "Tyler" };
            Employee<string> employee9 = new Employee<string>() { employeeNum = 9, FirstName = "Sam", LastName = "Dekker" };
            Employee<string> employee10 = new Employee<string>() { employeeNum = 10, FirstName = "Simone", LastName = "Farro" };

            // Create new list and add employees to it
            List<Employee<string>> employees = new List<Employee<string>>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            
            // Create new list for employees names Joe
            List<Employee<string>> employeesJoe = new List<Employee<string>>();


            // Parse through employee list and add every employee named Joe to the Joe list
            foreach (Employee<string> employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesJoe.Add(employee);
                }
            }
            // Print first and last name from list of Joes to confirm funcionality
            Console.WriteLine("\nEach 'Joe' from new list using foreach loop:");
            foreach (Employee<string> employee in employeesJoe)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

            // Do the same as before but using a lambda function
            Console.WriteLine("\nEach 'Joe' from new list using lambda function:");
            List<Employee<string>> employeesJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee<string> employee in employeesJoe2)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

            Console.WriteLine("\nEvery employee with an ID number greater than 5:");
            List<Employee<string>> employeeNum5plus = employees.Where(x => x.employeeNum > 5).ToList();
            foreach (Employee<string> employee in employeeNum5plus)
            {
                Console.WriteLine("{0}: {1} {2}", employee.employeeNum, employee.FirstName, employee.LastName);
            }


            // Print employee information
            //employee1.SayName();
            //employee2.SayName();
            //employee3.SayName();


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




            //if (employee1 == employee2)
            //{
            //    Console.WriteLine("\nOops. These employees have the same ID number.");
            //}
            //if (employee1 == employee3)
            //{
            //    string fullName1 = employee1.FirstName + " " + employee1.LastName;
            //    string fullName3 = employee3.FirstName + " " + employee3.LastName;
            //    Console.WriteLine("\n{0} and {1} have the same ID number.", fullName1, fullName3);
            //}

            IQuittable quittable = new Employee<string>();
            quittable.Quit();
             
        }
    }
}
