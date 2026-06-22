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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;";

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewGuests_Click(object sender, EventArgs e)
        {
            string error;
            var dt = DBHelper.ExecuteDataTable(connString, "SELECT * FROM Guest", CommandType.Text, null, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to load guests: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvGuests.DataSource = dt;
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuestID.Text, out int guestId))
            {
                MessageBox.Show("Please enter a valid numeric GuestID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error;
            var exists = DBHelper.RecordExists(connString, "SELECT COUNT(1) FROM Guest WHERE GuestID = @GuestID", new Dictionary<string, object> { { "@GuestID", guestId } }, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to verify guest: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!exists)
            {
                MessageBox.Show("Guest with the specified ID does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parameters = new Dictionary<string, object>
            {
                { "@GuestID", guestId },
                { "@FirstName", txtFName.Text },
                { "@LastName", txtLName.Text },
                { "@Email", txtEmail.Text },
                { "@Phone", txtPhone.Text }
            };

            // Prevent duplicate email/phone for a different guest
            var dupParams = new Dictionary<string, object>
            {
                { "@Email", txtEmail.Text },
                { "@Phone", txtPhone.Text },
                { "@GuestID", guestId }
            };
            var duplicate = DBHelper.RecordExists(connString, "SELECT COUNT(1) FROM Guest WHERE (Email = @Email OR Phone = @Phone) AND GuestID <> @GuestID", dupParams, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to validate duplicates: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (duplicate)
            {
                MessageBox.Show("Another guest with the same email or phone already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rows = DBHelper.ExecuteNonQuery(connString, "sp_UpdateGuest", CommandType.StoredProcedure, parameters, out error);
            if (!string.IsNullOrEmpty(error) || rows < 0)
            {
                MessageBox.Show($"Failed to update guest: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Guest Updated!");
        }
    }
}
