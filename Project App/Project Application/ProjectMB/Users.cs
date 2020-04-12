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
        public static int LastGenUsernameId()
        {
         List<User> usersResults = new List<User>();   
            foreach (var item in users)
            {
                if (item.Username.Contains("mbemp"))
                {
                    usersResults.Add(item);
                }
            }

            string lastUser = usersResults[usersResults.Count - 1].Username;
            int returnId = int.Parse(lastUser.Substring(5, lastUser.Length - 5));
            return returnId;
        }
        public static User[] FindUserByLastName(string lastName)
        {
            List<User> results = new List<User>();
            foreach (var item in users)
            {
                if (item.LastName == lastName)
                {
                   results.Add(item);
                }
            }
            return results.ToArray();
        }
        public static void AddUser(User user) 
        {
            DatabaseFunctions.AddUser(user);
            DatabaseFunctions.GetAllEmployees();
        }
        public static void UpdateUser(User user)
        {
            DatabaseFunctions.UpdateUser(user);
            DatabaseFunctions.GetAllEmployees();
        }
        public static void RemoveUser(User user)
        {
            DatabaseFunctions.RemoveUser(user);
            DatabaseFunctions.GetAllEmployees();
        }
    }
}
