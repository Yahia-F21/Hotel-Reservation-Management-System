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
    public partial class CreateResForm : Form
    {

        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;";
        public CreateResForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        private void btnSubmitCreateRes_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtResRoomID.Text, out int roomId))
            {
                MessageBox.Show("Please enter a valid numeric RoomID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var checkIn = dtpCheckIn.Value.Date;
            var checkOut = dtpCheckOut.Value.Date;
            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check room exists
            string error;
            var roomExists = DBHelper.RecordExists(connString, "SELECT COUNT(1) FROM [Room] WHERE RoomID = @RoomID", new Dictionary<string, object> { { "@RoomID", roomId } }, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to validate room: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!roomExists)
            {
                MessageBox.Show("Specified RoomID does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check room availability for the requested dates
            var overlapParams = new Dictionary<string, object>
            {
                { "@RoomID", roomId },
                { "@CheckIn", checkIn },
                { "@CheckOut", checkOut }
            };
            var overlapQuery = "SELECT COUNT(1) FROM Reservation WHERE RoomID = @RoomID AND NOT (CheckOut <= @CheckIn OR CheckIn >= @CheckOut)";
            var hasOverlap = DBHelper.RecordExists(connString, overlapQuery, overlapParams, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to check room availability: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasOverlap)
            {
                MessageBox.Show("Room is not available for the selected dates.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate guest by email or phone
            var guestDupParams = new Dictionary<string, object>
            {
                { "@Email", txtResEmail.Text },
                { "@Phone", txtResPhone.Text }
            };
            var guestExists = DBHelper.RecordExists(connString, "SELECT COUNT(1) FROM Guest WHERE Email = @Email OR Phone = @Phone", guestDupParams, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to validate guest: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (guestExists)
            {
                var result = MessageBox.Show("A guest with the same email or phone already exists. If you intended to create a reservation for an existing guest, please use the existing GuestID. Do you want to abort?", "Duplicate Guest", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) return;
            }

            var parameters = new Dictionary<string, object>
            {
                { "@FirstName", txtResFName.Text },
                { "@LastName", txtResLName.Text },
                { "@Email", txtResEmail.Text },
                { "@Phone", txtResPhone.Text },
                { "@RoomID", roomId },
                { "@CheckIn", checkIn },
                { "@CheckOut", checkOut }
            };

            int rows = DBHelper.ExecuteNonQuery(connString, "sp_CreateGuestAndReservation", CommandType.StoredProcedure, parameters, out error);
            if (!string.IsNullOrEmpty(error) || rows < 0)
            {
                MessageBox.Show($"Failed to create reservation: {error}\n\nConnection string: {connString}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Guest & Reservation Created!");
        }

        private void txtResFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
