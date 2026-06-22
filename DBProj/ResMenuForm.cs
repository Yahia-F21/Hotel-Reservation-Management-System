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
    public partial class ResMenuForm : Form
    {
        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;"; public ResMenuForm()
        {
            InitializeComponent();
        }

        private void btnGoCreateRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateResForm().ShowDialog();
            this.Show();
        }

        private void btnGoUpdateCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateCheckoutForm().ShowDialog();
            this.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
