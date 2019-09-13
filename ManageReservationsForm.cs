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
    public partial class ManageReservationsForm : Form
    {
        /// <summary>
        /// Some Extra Features
        ///         1. We need to add foreign keys for client and room to "tie" the tables toghether correctly and prevent errors
        /// -> for room: ALTER TABLE rooms ADD CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES rooms_category(category_id) on UPDATE CASCADE on DELETE CASCADE
        /// !The FOREIGN KEY constraint is used to prevent actions that would destroy links between tables.
        /// !ON DELETE CASCADE means that if the parent record is deleted, any child records are also deleted
        /// !ON UPDATE CASCADE means that if the parent primary key is changed, the child value will also change to reflect that.
        /// 
        /// -> for reservations : ALTER TABLE reservations ADD CONSTRAINT fk_room_number FOREIGN KEY (roomNumber) REFERENCES rooms(number) on UPDATE CASCADE on DELETE CASCADE
        ///                       ALTER TABLE reservations ADD CONSTRAINT fk_client_id FOREIGN KEY (clientID) REFERENCES clients(id) on UPDATE CASCADE on DELETE CASCADE
        ///         2. For reservations we need to show (in roomNumber combobox) only the available rooms in a certain time period
        /// -> "SELECT * FROM `rooms` WHERE `type`=@typ and !!`free`='YES'!!"
        ///         3. After the user adds a reservation we need to update the table rooms -> column free -> yes/no
        /// ->  command.CommandText = "UPDATE `rooms` SET`free`='NO' WHERE `number`=@numb";
        /// ->   ROOM.roomToNo(RoomNumber);
        ///         4. Fix the dates : date in must be >= today date , date out must be >= date in 
        /// ->  ! When you delete a client or a room all the reservations associated to it will also be deleted due to the foreign keys 
        /// </summary>




        reservation Reservation = new reservation();
        room ROOM = new room();
        public ManageReservationsForm()
        {
            InitializeComponent();
        }


        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            //display the reservations in the datagrid
            dataGridView1.DataSource = Reservation.getReservations();

            //display room`s type
            comboBoxRoomType.DataSource = ROOM.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            //display free room`s number depending on the selected type
            try
            {
                //display room`s number depending on the selected type
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = ROOM.roombyType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch (Exception Ex)
            {
               
            }
            
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            // The clear fields button which erases the existent data from the textboxes
            textBoxReservID.Text = "";
            textBoxClientID.Text = "";
            textBoxReservID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimeIN.Value = DateTime.Now;
            dateTimeOUT.Value = DateTime.Now;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This event takes place when we change the selected item from the RoomType combobox
            //In our case we need to search again the room numbers at any change of RoomType combobox during the execution of the program
            try
            {
                //display room`s number depending on the selected type
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = ROOM.roombyType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch (Exception Ex)
            {
              // We don`t need to use an error message because we only want to get rid of the execption
              // If we use an error message it will always appear when we open the Reservations Menu which is a problem 
            }
           
        }

        private void AddReservation_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the data from the textboxes plus data conversion
                int ClientID = Convert.ToInt32(textBoxClientID.Text);
                int RoomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIN = dateTimeIN.Value;
                DateTime dateOUT = dateTimeOUT.Value;

                // Checking the calendaristic dates
                if (DateTime.Compare(dateIN,DateTime.Now.Date)<0)
                {
                    MessageBox.Show("Date In must be > or = to Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOUT,dateIN)<0)
                     {
                    MessageBox.Show("Date OUT must be > or = to Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     else
                     {
                         //adding plus verification
                       if (Reservation.addReservation(RoomNumber, ClientID, dateIN, dateOUT) == true)
                       {
                        // When a reservation is made it will set the room free status to NO
                        ROOM.roomToNo(RoomNumber);
                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = Reservation.getReservations();
                       }
                       else
                       {
                        MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }


                     }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
             
        }

        private void EditReservation_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the data from the textboxes plus data conversion
                int ReservID = Convert.ToInt32(textBoxReservID.Text);
                int ClientID = Convert.ToInt32(textBoxClientID.Text);
                int RoomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIN = dateTimeIN.Value;
                DateTime dateOUT = dateTimeOUT.Value;

                // Checking the calendaristic dates
                if (dateIN < DateTime.Now)
                {
                    MessageBox.Show("Date In must be > or = to Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOUT < dateIN)
                {
                    MessageBox.Show("Date OUT must be > or = to Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                    if (Reservation.editReservation(ReservID,RoomNumber, ClientID, dateIN, dateOUT) == true)
                    {
                        // When a reservation is made it will set the room free status to NO
                        ROOM.roomToNo(RoomNumber);
                        MessageBox.Show("Reservation Updated Successfully", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = Reservation.getReservations();
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Display the selected data from the datagrid to textboxes
            textBoxReservID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxClientID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            // get the room id
            int roomid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            // select the room type from the combobox
            comboBoxRoomType.SelectedValue = ROOM.getroomtype(roomid);
            // select the room number from the combobox
            comboBoxRoomNumber.SelectedValue = roomid;
            // get the date in and date out 
            dateTimeIN.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            dateTimeOUT.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());

        }

        private void RemoveReservation_Click(object sender, EventArgs e)
        {
            try
            {
                int reservid = Convert.ToInt32(textBoxReservID.Text);
                int roomnumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (Reservation.removeReservation(reservid)==true)
                {
                    MessageBox.Show("Reservation Removed Successfully", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = Reservation.getReservations();
                    //After we remove a reservation we need to set the free status to "YES"
                    ROOM.roomToYes(roomnumber);
                }
                else
                {
                    MessageBox.Show("Reservation NOT Removed", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
