using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    class Users
    {
        public static List<User> users = new List<User>();
        public static List<User> employees = new List<User>();
        public Users()
        { }
        public User FindUserByUsername(string username)
        {
            foreach (var item in users)
            {
                if (item.Username == username)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
