using Microsoft.EntityFrameworkCore;

namespace FinalChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student();
                student.StudentName = "Bill";

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }

}
