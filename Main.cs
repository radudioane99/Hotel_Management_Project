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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF= new ManageClientsForm();
            manageCF.ShowDialog();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();
            manageRF.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageRSVF = new ManageReservationsForm();
            manageRSVF.ShowDialog();
        }
    }
}
