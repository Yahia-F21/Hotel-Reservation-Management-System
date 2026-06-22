using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBProj
{
    public partial class MainScene : Form
    {
        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;"; public MainScene()
        {
            InitializeComponent();
        }

        private void btnGoGuest_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide main scene
            new GuestForm().ShowDialog(); // Open Guest scene
            this.Show(); // Show main scene again when Guest scene closes
        }

        private void btnGoRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RoomForm().ShowDialog();
            this.Show();
        }

        private void btnGoRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ResMenuForm().ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoRes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new ResMenuForm().ShowDialog();
            this.Show();
        }
    }
}
