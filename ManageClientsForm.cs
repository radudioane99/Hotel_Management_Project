using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_Management
{
    public partial class ManageClientsForm : Form
    {
        // We instantiate an object of the class client to work with it 
        client Client = new client();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    

        private void add_Click(object sender, EventArgs e)
        {
            // Obtaining the data from the textboxes and setting the variables for the insert command
            String fname = firstnametext.Text;
            String lname = lastnametext.Text;
            String phone = phonetext.Text;
            String country = countrytext.Text;

                        // INSERT COMMAND

            // If one of the textboxes is empty we send a warning else we insert the new client
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("Please Fill In All the Data ", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // The process of adding a new client : The boolean type will return 1 if everything is ok ( see client class )
                Boolean insertclient = Client.insertClient(fname, lname, phone, country);

                // The verification process
                if (insertclient == true)
                {
                    MessageBox.Show("New Client Inserted Successfuly", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = Client.getClients();
                    //!!! Refreshes the datagrid when we insert a new client in order to see the changes instantaneously
                }
                else
                {
                    MessageBox.Show("Error! Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            // The LOAD event occurs before a form is displayed for the first time. 
            // So we will use it to update our data grid with information provided from the getClients method defined in client class.
            // This event takes place right before we open the "Manage Clients" menu so the information will be presented on the data grid.
            dataGridView1.DataSource = Client.getClients();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id;
            //!! If the id textbox is empty than the conversion to int will cause an exception
            // We solve this using try&catch mechanism
            // If id is not empty, then the edit mechanism and the conversion are made otherwise we "solve" the exception by an error message
            try
            {
                id = Convert.ToInt32(idtext.Text);
                String fname = firstnametext.Text;
                String lname = lastnametext.Text;
                String phone = phonetext.Text;
                String country = countrytext.Text;
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("Please Fill In All the Data ", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // The process of editing a new client : The boolean type will return 1 if everything is ok ( see client class )
                    Boolean updateclient = Client.editClient(id, fname, lname, phone, country);

                    // The verification process
                    if (updateclient == true)
                    {
                        MessageBox.Show("New Client Updated Successfuly", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = Client.getClients();
                        //!!! Refreshes the datagrid when we edit a new client in order to see the changes instantaneously
                    }
                    else
                    {
                        MessageBox.Show("Error! Client Not Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //!!! IMPORTANT - copy the data from the datagrid to the input textboxes (easy to edit)
            // This event takes place when you click on a row from the datagrid
            idtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstnametext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastnametext.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phonetext.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            countrytext.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(idtext.Text);
                // The process of removing a new client : The boolean type will return 1 if everything is ok ( see client class )
                Boolean removeclient = Client.removeClient(id);

                // The verification process
                if (removeclient == true)
                {
                    MessageBox.Show("Client Removed Successfuly", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = Client.getClients();
                    //!!! Refreshes the datagrid when we remove a new client in order to see the changes instantaneously

                    // IMPORTANT!!! This is how you call a button actions when another button is pressed (virtual click)
                    clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error! Client Not Removed", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // The "Clear Fields" button which just deletes the text from the textboxes 
            idtext.Text = "";
            firstnametext.Text = "";
            lastnametext.Text = "";
            phonetext.Text = "";
            countrytext.Text = "";
        }
    }
}
