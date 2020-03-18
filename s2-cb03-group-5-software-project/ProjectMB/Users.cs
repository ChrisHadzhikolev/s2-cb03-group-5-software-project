using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    static class Users
    {
        public static List<User> users = new List<User>();
        public static List<User> Employees = new List<User>();
        public static string Department = "";
        
        public static User FindUserByUsername(string username)
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
