using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    class DatabaseFunctions
    {
        protected string connectionString;
        public DatabaseFunctions()
        {
            connectionString = "server=studmysql01.fhict.local;database=dbi428428;uid=dbi428428;password=spiderMan2000;";
        }
        public bool GetAllUsers()
        {
            string query = "Select * from people as p join working_days as wd on p.username = wd.username";
            try
            {                
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    List<User> results = new List<User>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        int id = Int32.Parse(dataReader[0].ToString());
                        string username = dataReader[1].ToString();
                        string firstName = dataReader[2].ToString();
                        string lastName = dataReader[3].ToString();
                        string email = dataReader[4].ToString();
                        PersonPosition position = (PersonPosition)Enum.Parse(typeof(PersonPosition), dataReader[5].ToString(), true);
                        double salary = Int32.Parse(dataReader[6].ToString());
                        string department = dataReader[7].ToString();

                        ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), dataReader[10].ToString(), true);
                        bool[] days = new bool[7];
                        
                        for (int i = 0; i < 7; i++)
                        {
                            days[i] = bool.Parse(dataReader[i + 11].ToString());                            
                        }
                        User user = new User(id, username, firstName, lastName, email, position, salary, shiftType, days, department);
                        results.Add(user);
                    }
                    conn.Close();
                    Users.users.Clear();
                    Users.users.AddRange(results);
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }
            //DBHelper.ReaderQuery(query, 10);

            return true;
        }
        
        public bool GetEmployeesByDepartment(string departmentName)
        {
            string query = "Select * from people as p join working_days as wd on p.username = wd.username where department = @departmentName and position = 'EMPLOYEE' ";
            try
            {                
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    List<User> results = new List<User>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        int id = Int32.Parse(dataReader[0].ToString());
                        string username = dataReader[1].ToString();
                        string firstName = dataReader[2].ToString();
                        string lastName = dataReader[3].ToString();
                        string email = dataReader[4].ToString();
                        PersonPosition position = (PersonPosition)Enum.Parse(typeof(PersonPosition), dataReader[5].ToString(), true);
                        double salary = Int32.Parse(dataReader[6].ToString());
                        string department = dataReader[7].ToString();

                        ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), dataReader[10].ToString(), true);
                        bool[] days = new bool[7];
                        
                        for (int i = 0; i < 7; i++)
                        {
                            days[i] = bool.Parse(dataReader[i + 11].ToString());                            
                        }
                        User user = new User(id, username, firstName, lastName, email, position, salary, shiftType, days, department);
                        results.Add(user);
                    }
                    conn.Close();
                    Users.employees.Clear();
                    Users.employees.AddRange(results);
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }
            return true;
        }
        public string PasswordByUsername(string username)
        {
            string query = "select password from users where username = @username";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                Object obj = cmd.ExecuteScalar();
                conn.Close();
                return obj.ToString();
            }


        }

        public bool AddUser(User user)
        {
            MySqlCommand cmd;
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "Insert into people (`id`, `username`, `first_name`, `last_name`, `email`, `position`, `salary`, `department`) values (null, @username, @first_name, @last_name, @email,'EMPLOYEE', @salary, @department);";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@salary", user.Salary);
                cmd.Parameters.AddWithValue("@department", user.Department);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "insert into users (`id`, `username`, `password`, `Platform`) VALUES (null, @username, @pass, 'WEB');";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@pass", user.GeneratePassword());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                query = "insert into working_days (`id`, `username`, `shift`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`) values (null, @username, @shift, @monday, @tuesday, @wednesday, @thursday, @friday, @saturday, @sunday);";
                
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@shift", user.ShiftTypeU.ToString());
                cmd.Parameters.AddWithValue("@monday", user.WorkingDays[0]);
                cmd.Parameters.AddWithValue("@tuesday", user.WorkingDays[1]);
                cmd.Parameters.AddWithValue("@wednesday", user.WorkingDays[2]);
                cmd.Parameters.AddWithValue("@thursday", user.WorkingDays[3]);
                cmd.Parameters.AddWithValue("@friday", user.WorkingDays[4]);
                cmd.Parameters.AddWithValue("@saturday", user.WorkingDays[5]);
                cmd.Parameters.AddWithValue("@sunday", user.WorkingDays[6]);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }
        public bool UpdateUser() { return true; }
        public bool SelectUser() { return true; }
        public bool RemoveUser(User user)
        {
            
                MySqlCommand cmd;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM people WHERE username=@username;";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@salary", user.Salary);
                    cmd.Parameters.AddWithValue("@department", user.Department);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                query = "DELETE FROM users WHERE username=@username;";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@pass", user.GeneratePassword());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    query = "DELETE FROM working_days WHERE username=@username;";

                    cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@shift", user.ShiftTypeU.ToString());
                    cmd.Parameters.AddWithValue("@monday", user.WorkingDays[0]);
                    cmd.Parameters.AddWithValue("@tuesday", user.WorkingDays[1]);
                    cmd.Parameters.AddWithValue("@wednesday", user.WorkingDays[2]);
                    cmd.Parameters.AddWithValue("@thursday", user.WorkingDays[3]);
                    cmd.Parameters.AddWithValue("@friday", user.WorkingDays[4]);
                    cmd.Parameters.AddWithValue("@saturday", user.WorkingDays[5]);
                    cmd.Parameters.AddWithValue("@sunday", user.WorkingDays[6]);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            
        }
        public bool AddProduct() { return true; }
        public bool UpdateProduct() { return true; }
        public bool SelectProduct() { return true; }
        public bool RemoveProduct() { return true; }


    }
}
