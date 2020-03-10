using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class DBHelper
    {
        public string connectionString { get; private set; }
        public DBHelper()
        {
            connectionString = "server=studmysql01.fhict.local;database=dbi428428;uid=dbi428428;password=spiderMan2000;";
        }

        public bool NonQuery(string query)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }

        }
        public Object ScalarQuery(string query)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    Object obj = cmd.ExecuteScalar();
                    conn.Close();
                    return obj;
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }
        }
        
    }
}