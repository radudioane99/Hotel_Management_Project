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
    public partial class ManageRoomsForm : Form
    {
        room ROOM = new room();
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            // Selects from the database the room types and use it as datasource for combobox
            // It will display the items from the "label" column but will consider explicitly the "category_id" values 
            comboBoxRoomType.DataSource = ROOM.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            //Update our data grid with information provided from the getRooms method defined in room class.
            dataGridView1.DataSource = ROOM.getRooms();
        }

        private void addroom_Click(object sender, EventArgs e)
        {
            // Extracting the parameters from the textboxes and data conversion for the ADD command
            try
            {
                int numb = Convert.ToInt32(numbertext.Text);
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                string phone = phonetext.Text;
                string free = "";
                if (radioNO.Checked == true) { free = "NO"; }
                if (radioYES.Checked == true) { free = "YES"; }
                // ADD COMMAND + verification
                if (numb == 0 || type == 0 || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Please Fill In All the Data ", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ROOM.addRoom(numb, type, phone, free) == true)
                    {
                        MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ROOM.getRooms();
                    }
                    else
                    {
                        MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void removeroom_Click(object sender, EventArgs e)
        {
            //  Preparing the values for the delete command
            try
            {
                int number = Convert.ToInt32(numbertext.Text);

                // Delete command + verification
                if (ROOM.removeRoom(number) == true)
                {
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ROOM.getRooms();
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editroom_Click(object sender, EventArgs e)
        {
            // Preparing the values for the update command + data conversion
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String phone = phonetext.Text;
            String free="";

            try
            {
                int number = Convert.ToInt32(numbertext.Text);
                // Radiobuttons output 
                if (radioYES.Checked)
                {
                    free = "YES";
                }
                if (radioNO.Checked)
                {
                    free = "NO";
                }

                // Update command plus verification
                if (ROOM.editRoom(number, type, phone, free) == true)
                {
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ROOM.getRooms();
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    
        private void clear_Click(object sender, EventArgs e)
        {
            //Empty the textboxes
            numbertext.Text = "";
            comboBoxRoomType.SelectedIndex = 0; // 0 -> single
            phonetext.Text = "";
            radioYES.Checked = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Display the selected data from the datagrid to textboxes
            numbertext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            phonetext.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //To show when you select a room it's type (single , double , suite)
            comboBoxRoomType.SelectedValue= dataGridView1.CurrentRow.Cells[1].Value;
            //Taking the information about the room status and display it via YES and NO RadioButtons
            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (free.Equals("YES"))
            {
                radioYES.Checked = true;
            }
            else if (free.Equals("NO"))
            {
                radioNO.Checked = true;
            }

        }

       
    }
}
