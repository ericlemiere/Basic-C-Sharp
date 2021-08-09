using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int employeeNum;

        // Override inherited class method (can now be accessed from main method)
        public override void SayName()
        {
            Console.Write("ID: {0} - ", employeeNum);
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("\nPress Any Key to Quit Program.");
        }
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.employeeNum == employee2.employeeNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.employeeNum != employee2.employeeNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
