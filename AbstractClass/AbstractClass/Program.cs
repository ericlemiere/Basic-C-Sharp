using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new employee and print name to console.
            Employee employee1 = new Employee() { employeeNum = 1, FirstName = "Sarah", LastName = "Connor" };
            Employee employee2 = new Employee() { employeeNum = 2, FirstName = "John", LastName = "Daily" };
            Employee employee3 = new Employee() { employeeNum = 1, FirstName = "Quinn", LastName = "Jackson" };



            employee1.SayName();
            employee2.SayName();
            employee3.SayName();

            if (employee1 == employee2)
            {
                Console.WriteLine("Oops. These employees have the same ID number.");
            }
            if (employee1 == employee3)
            {
                string fullName1 = employee1.FirstName + " " + employee1.LastName;
                string fullName3 = employee3.FirstName + " " + employee3.LastName;
                Console.WriteLine("{0} and {1} have the same ID number.", fullName1, fullName3);
            }

            IQuittable quittable = new Employee();
            quittable.Quit();

        }
    }
}
