using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HOTEL_Management
{
    // This class will make the connection between mysql database and this application
    class connect
    {
        // We initialize a private variable "connection" of special type : MySqlConnection to make connection to our database.This is done via parameters below.
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");

        // We need a function to return our connection
        public MySqlConnection getConnection()
        {
            return connection;
        }

        // We need a function to open our connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        // We need a function to close our connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
