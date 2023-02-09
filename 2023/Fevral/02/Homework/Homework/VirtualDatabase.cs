using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class VirtualDatabase
    {
        public static List<User> users = new List<User>();

        public void AddUser(User addingUser)
        {
            users.Add(addingUser);
        }

        public bool RemoveUser(string name, string surName) 
        {
            foreach(User user in users)
            {
                if (user.Name == name && user.SurName == surName)
                {
                    users.Remove(users[users.IndexOf(user)]);
                    return true;
                }
            }
            return false;
        }
    }
}
