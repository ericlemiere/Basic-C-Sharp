using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize first employee with id and name
            Employee employee1 = new Employee() { id = 1, FirstName = "Sample", LastName = "Student" };
            // Print name to console
            employee1.SayName();
        }
    }
}
