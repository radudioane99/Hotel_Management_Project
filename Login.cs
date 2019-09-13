using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HOTEL_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            // Initialize the elements we need for working with a database
            connect conn = new connect();   // Connect class!
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`= @usd AND `password`= @pass";

            // the command variable belonging to the class "MySqlCommand" recieve two parameters : The SQL command(Text) and the connection to the database
            command.CommandText = query;
            command.Connection = conn.getConnection();

            // Adding parameters from the textboxes in login form
            command.Parameters.Add("@usd", MySqlDbType.VarChar).Value = usertext.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passtext.Text;

            // the adapter variable recieves the command we will execute on the database and will refresh it using Fill command. Via an "MySqlCommand" object it performs changes on a database.
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // If the username and the password exist
            if (table.Rows.Count > 0)
            {
                // We hide the login form , instantiate a new form main and show it on the screen
                this.Hide();
                Main mform = new Main();
                mform.Show();

            }
            else
            {
                // All the error messages which can occur: if the user or password textbox is empty, or if one of them are not correct
                if (usertext.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Username to login ", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passtext.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password to login ", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or Password is incorect or doesn't exist", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
}
