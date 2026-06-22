using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProj
{
    public partial class RoomForm : Form
    {

        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;"; public RoomForm()
        {
            InitializeComponent();
        }

       

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_RoomDetails", conn);
                DataTable dt = new DataTable(); da.Fill(dt);
                dgvRooms.DataSource = dt;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateRoomPrice", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomID", int.Parse(txtRoomID.Text));
                cmd.Parameters.AddWithValue("@NewPrice", decimal.Parse(txtPrice.Text));
                conn.Open(); cmd.ExecuteNonQuery();
                MessageBox.Show("Room Price Updated!");
            }
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
