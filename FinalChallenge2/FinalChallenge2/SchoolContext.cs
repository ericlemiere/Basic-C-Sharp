using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FinalChallenge2
{
    class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
