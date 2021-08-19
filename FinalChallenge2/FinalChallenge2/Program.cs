using System;

namespace FinalChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter New Student's Name:");
            string name = Console.ReadLine();

            using (var db = new SchoolContext())
            {
                var student = new Student();
                student.StudentName = name;

                db.Students.Add(student);
                db.SaveChanges();
            }
            Console.WriteLine("{0} added", name);
        }
    }

}
