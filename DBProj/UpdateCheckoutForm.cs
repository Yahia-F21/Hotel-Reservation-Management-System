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
    public partial class UpdateCheckoutForm : Form
    {
        string connString = "Server=desktop-4uwhzp7\\sqlexpress;Database=HotelReservationDB;Integrated Security=True;";

        public UpdateCheckoutForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }

        private void btnUpdateResDate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUpdResID.Text, out int resId))
            {
                MessageBox.Show("Please enter a valid numeric Reservation ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCheckOut = dtpNewCheckOut.Value.Date;

            // Verify reservation exists and get current check-in and room
            string error;
            var resTable = DBHelper.ExecuteDataTable(connString, "SELECT RoomID, CheckIn FROM Reservation WHERE ResID = @ResID", CommandType.Text, new Dictionary<string, object> { { "@ResID", resId } }, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to validate reservation: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (resTable.Rows.Count == 0)
            {
                MessageBox.Show("Reservation ID not found.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = resTable.Rows[0];
            int roomId = Convert.ToInt32(row["RoomID"]);
            DateTime currentCheckIn = Convert.ToDateTime(row["CheckIn"]);

            if (newCheckOut <= currentCheckIn)
            {
                MessageBox.Show("New check-out must be after the original check-in.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for overlaps with other reservations for the same room
            var overlapParams = new Dictionary<string, object>
            {
                { "@RoomID", roomId },
                { "@CheckIn", currentCheckIn },
                { "@CheckOut", newCheckOut },
                { "@ResID", resId }
            };
            var overlapQuery = "SELECT COUNT(1) FROM Reservation WHERE RoomID = @RoomID AND ResID <> @ResID AND NOT (CheckOut <= @CheckIn OR CheckIn >= @CheckOut)";
            var hasOverlap = DBHelper.RecordExists(connString, overlapQuery, overlapParams, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to check reservation conflicts: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasOverlap)
            {
                MessageBox.Show("Cannot update: the new dates conflict with another reservation for the same room.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rows = DBHelper.ExecuteNonQuery(connString, "sp_UpdateReservationDate", CommandType.StoredProcedure, new Dictionary<string, object> { { "@ResID", resId }, { "@NewCheckOut", newCheckOut } }, out error);
            if (!string.IsNullOrEmpty(error) || rows < 0)
            {
                MessageBox.Show($"Failed to update reservation: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Reservation Dates Updated!");
        }

        private void btnSubmitCheckout_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCheckoutGuestID.Text, out int guestId))
            {
                MessageBox.Show("Please enter a valid numeric GuestID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCheckoutPayMethod.Text))
            {
                MessageBox.Show("Please enter a payment method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error;
            var guestExists = DBHelper.RecordExists(connString, "SELECT COUNT(1) FROM Guest WHERE GuestID = @GuestID", new Dictionary<string, object> { { "@GuestID", guestId } }, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Failed to validate guest: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!guestExists)
            {
                MessageBox.Show("GuestID not found.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rows = DBHelper.ExecuteNonQuery(connString, "sp_ProcessCheckoutByGuest", CommandType.StoredProcedure, new Dictionary<string, object> { { "@GuestID", guestId }, { "@PaymentMethod", txtCheckoutPayMethod.Text } }, out error);
            if (!string.IsNullOrEmpty(error) || rows < 0)
            {
                MessageBox.Show($"Failed to complete checkout: {error}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Checkout Completed Successfully!");
        }
    }
}
