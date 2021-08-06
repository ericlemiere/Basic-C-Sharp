using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new employee and print name to console.
            Employee employee1 = new Employee() { FirstName = "Sarah", LastName = "Connor" };
            employee1.SayName();
        }
    }
}
