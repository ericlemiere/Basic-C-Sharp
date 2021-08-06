using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        // Override inherited class method (can now be accessed from main method)
        public override void SayName()
        {
            base.SayName();
        }

    }
}
