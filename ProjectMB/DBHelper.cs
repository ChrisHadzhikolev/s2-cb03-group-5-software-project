/*
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
*/