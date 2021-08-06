using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;

        // Method to print name to console
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
