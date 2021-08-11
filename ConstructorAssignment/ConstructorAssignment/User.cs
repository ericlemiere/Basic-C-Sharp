using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    class User
    {
        public int userId;
        public string userName;
        public string userOccupation;
        public User(int id) : this(id, "", "")
        {

        }
        public User(int id, string name) : this(id, name, "")
        {

        }
        public User(int id, string name, string occupation)
        {
            userId = id;
            userName = name;
            userOccupation = occupation;
        }
    }
}
