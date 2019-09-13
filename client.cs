using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HOTEL_Management
{
    /* create a class client to add a new client
         *                          remove client
         *                          edit client data
         *                          get all clients
    */
    class client
    {
        // Establishing a new connection to the database
        connect conn = new connect();



        // INSERT FUNCTION
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            // Constructing a new command via it`s parameters : CommandText,Connection  +  the sql query
            MySqlCommand command = new MySqlCommand();
            String insertquery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertquery;
            command.Connection = conn.getConnection();

            // Adding the parameters 

            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            // We will make changes to the database so we need to open the connection and close it VIA the class connect methods
            conn.openConnection();
            // If the number of rows affected is equal to one (the added one) everything is ok so we return true else we return false + close connection  
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }


        }


        // Function which gets the clients list
        public DataTable getClients()
        {
            // We create a new command directly which has as parameters : the text of the command and the connection
            MySqlCommand comm = new MySqlCommand("SELECT * FROM `clients`", conn.getConnection());

            // We instantiate a new table to store the final result
            DataTable table = new DataTable();

            // We will use a data adapter which has as parameters the command and using the adapter we will store the result in the new empty table
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comm;
            adapter.Fill(table);

            // We will return the table with information ( look at the method definition)
            return table;
        }
         // EDIT FUNCTION
        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            String editquery = "UPDATE `clients` SET `first_name`=@fname,`last_name`=@lname,`phone`=@phone,`country`=@country WHERE `id`=@ID";

            command.CommandText = editquery;
            command.Connection = conn.getConnection();
            // Adding parameters to the command 
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = country;
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            // Open the connection , check if the number of rows modified is 1 , return true/false to see if everything went ok or not and close connection
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }


        }
        //REMOVE FUNCTION
        public bool removeClient(int id)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `clients` WHERE `id`= @id";
            command.Connection = conn.getConnection();

            // Adding parameters to the command 
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            // Open the connection , check if the number of rows modified is 1 , return true/false to see if everything went ok or not and close connection
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.getConnection();
                return false;
            }
        }
        
    }
}
