using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHotel
{
    public class DatabaseConnector
    {
        private MySqlConnection Connection = new("server=localhost;port=3306;username=root;password=password_01;database=hoteldatabase");

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return Connection;
        }
    }
}
