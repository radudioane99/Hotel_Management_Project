using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HOTEL_Management
{
    // In this class we will manage rooms
    // First, we create 2 tables : room_type , rooms
    class room
    {
        // FUNCTION THAT GET A LIST OF ROOM'S TYPES
        connect conn = new connect();
        public DataTable roomTypeList()
        {
            // creating a new data table (using System.Data)
            DataTable table = new DataTable();

            // creating a new command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "SELECT * FROM `rooms_category` ";

            // creating a data adapter and storing the result (after the command filters the table) in a new table
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }



        // FUNCTION THAT GET A LIST OF ROOMS DEPENDING ON THEIR TYPE AND FREE COLUMN
        public DataTable roombyType(int type)
        {
            // creating a new data table (using System.Data)
            DataTable table = new DataTable();

            // creating a new command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "SELECT * FROM `rooms` WHERE `type`=@typ and `free`='YES'";

            //Adding the type parameter
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;

            // creating a data adapter and storing the result (after the command filters the table) in a new table
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //FUNCTION THAT GETS ROOM`S TYPE
        public int getroomtype(int number)
        {
            // creating a new data table (using System.Data)
            DataTable table = new DataTable();

            // creating a new command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "SELECT `type` FROM `rooms` WHERE `number`=@num";

            //Adding the type parameter
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            // creating a data adapter and storing the result (after the command filters the table) in a new table
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }


        // FUNCTION WHICH SET ROOM FREE COLUMN TO NO
        public bool roomToNo (int number)
        {

            // creating a new command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "UPDATE `rooms` SET`free`='NO' WHERE `number`=@numb";

            //Adding the type parameter
            command.Parameters.Add("@numb", MySqlDbType.Int32).Value = number;
            conn.openConnection(); // Opens the connection with the database
            //Checking if the row is updated 
            if (command.ExecuteNonQuery()==1)
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

        // FUNCTION WHICH SET ROOM FREE COLUMN TO YES
        public bool roomToYes(int number)
        {

            // creating a new command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "UPDATE `rooms` SET`free`='YES' WHERE `number`=@numb";

            //Adding the type parameter
            command.Parameters.Add("@numb", MySqlDbType.Int32).Value = number;
            conn.openConnection(); // Opens the connection with the database
            //Checking if the row is updated 
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

        // FUNCTION THAT ADDS A ROOM
        public bool addRoom(int number, int type, String phone, String free)
        {
            // Constructing a new command via it`s parameters : CommandText,Connection  +  the sql query
            MySqlCommand command = new MySqlCommand();
            String insertquery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES(@num, @tp, @phn, @fr)";
            command.CommandText = insertquery;
            command.Connection = conn.getConnection();

            // Adding the parameters 

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

            // FUNCTION WHICH GETS A LIST OF ALL ROOMS

            public DataTable getRooms()
            {
                // create a table to store the result and than return it 
                DataTable table = new DataTable();

                // create the command
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn.getConnection();
                command.CommandText = "SELECT * FROM `rooms` ";
                
                // create the adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

               return table;
            }

        // FUNCTION FOR EDITING

        public bool editRoom(int number, int type, String phone, String free)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.getConnection();
            command.CommandText = "UPDATE `rooms` SET `type`= @typ,`phone`= @phn,`free`= @fe WHERE `number`= @numb";
           
            // Adding parameters to the command 
            command.Parameters.Add("@numb", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fe", MySqlDbType.VarChar).Value = free;

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
        public bool removeRoom(int number)
        {
            // Setting the command attributes and the SQL query 
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `rooms` WHERE `number`= @numb";
            command.Connection = conn.getConnection();

            // Adding parameters to the command 
            command.Parameters.Add("@numb", MySqlDbType.Int32).Value =number;

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
