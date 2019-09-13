using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HOTEL_Management
{
    class reservation
    {
        //FUNCTION WHICH GETS ALL RESERVATIONS
        connect conn = new connect();
        public DataTable getReservations()
        {
            // Create a new data table to store the result
            DataTable table = new DataTable();

            // Creating the command using :  command.Connection, command.CommandText
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "SELECT * FROM `reservations` ";

            // Creating the adapter , givng the command as a parameter and storing the result in the table
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        // FUNCTION THAT ADDS A RESERVATION
        public bool addReservation(int number, int ClientID, DateTime DateIN, DateTime DateOut)
        {
     
            // Constructing a new command via it`s parameters : CommandText,Connection  +  the sql query
            MySqlCommand command = new MySqlCommand();
            String insertquery = "INSERT INTO `reservations`(`roomNumber`, `ClientID`, `DateIN`, `DateOut`) VALUES(@num, @cid, @din, @dout)";
            command.CommandText = insertquery;
            command.Connection = conn.getConnection();

            // Adding the parameters 

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = ClientID;
            command.Parameters.Add("@din", MySqlDbType.DateTime).Value = DateIN;
            command.Parameters.Add("@dout", MySqlDbType.DateTime).Value = DateOut;

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

        // FUNCTION FOR EDITING
        public bool editReservation(int reservID , int number, int ClientID, DateTime DateIN, DateTime DateOut)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "UPDATE `reservations` SET `roomNumber`=@numb,`clientID`=@cid,`DateIN`=@din,`DateOUT`=@dout WHERE `reservID`=@resid";

            // Adding parameters to the command 

            command.Parameters.Add("@numb", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = ClientID;
            command.Parameters.Add("@din", MySqlDbType.DateTime).Value = DateIN;
            command.Parameters.Add("@dout", MySqlDbType.DateTime).Value = DateOut;
            command.Parameters.Add("@resid", MySqlDbType.Int32).Value = reservID;

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
        public bool removeReservation(int reservid)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `reservations` WHERE `reservID`=@id";
            command.Connection = conn.getConnection();

            // Adding parameters to the command 
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = reservid;

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
