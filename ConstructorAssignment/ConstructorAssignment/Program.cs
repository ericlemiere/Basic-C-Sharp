using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string programName = "Visual Studio";
            var userName = "Tom Hanks";
            Console.WriteLine("{0} is an avid user of {1}", userName, programName);

            User user1 = new User(1, "Miles Bridges");
            Console.WriteLine("{0}: {1} {2}", user1.userId, user1.userName, user1.userOccupation);

            User user2 = new User(2, "Devin Booker", "Doctor");
            Console.WriteLine("{0}: {1}, {2}", user2.userId, user2.userName, user2.userOccupation);


        }
    }
}
