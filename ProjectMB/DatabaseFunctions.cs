using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class DatabaseFunctions : DBHelper
    {       
        DBHelper DBHelper;
        public DatabaseFunctions()
        {
            DBHelper = new DBHelper();
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
                        PersonPosition position = (PersonPosition) Enum.Parse(typeof(PersonPosition), dataReader[5].ToString(), true);
                        double salary = Int32.Parse(dataReader[6].ToString());
                        string department = dataReader[7].ToString();

                        ShiftType shiftType  = (ShiftType)Enum.Parse(typeof(ShiftType), dataReader[10].ToString(), true);
                        bool[] days = new bool[7];
                        List<WeekDay> workingDays = new List<WeekDay>();
                        for (int i = 0; i < 7; i++)
                        {
                            if (bool.Parse(dataReader[i + 11].ToString()))
                            {
                                switch (i)
                                {
                                    case 0:
                                        workingDays.Add(WeekDay.MONDAY);
                                    break;
                                    case 1:
                                        workingDays.Add(WeekDay.TUESDAY);
                                        break;
                                    case 2:
                                        workingDays.Add(WeekDay.WEDNESDAY);
                                        break;
                                    case 3:
                                        workingDays.Add(WeekDay.THURSDAY);
                                        break;
                                    case 4:
                                        workingDays.Add(WeekDay.FRIDAY);
                                        break;
                                    case 5:
                                        workingDays.Add(WeekDay.SATURDAY);
                                        break;
                                    case 6:
                                        workingDays.Add(WeekDay.SUNDAY);
                                        break;
                                }
                            }
                        }
                        
                        
                        User user = new User(id, username, firstName, lastName, email, position, salary, shiftType, workingDays.ToArray(),department); 
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

        public bool AddUser() { return true; }        
        public bool UpdateUser() { return true; }
        public bool SelectUser() { return true; }
        public bool RemoveUser() { return true; }
        public bool AddProduct() { return true; }
        public bool UpdateProduct() { return true; }
        public bool SelectProduct() { return true; }
        public bool RemoveProduct() { return true; }


    }
}
