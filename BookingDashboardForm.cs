using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class BookingDashboardForm : Form
    {
        private AdminManager adminManager = new AdminManager();  

        public BookingDashboardForm()
        {
            InitializeComponent(); 
            LoadBookingsData();    
            txtBookingId.ReadOnly = true;  
        }

        
        private void LoadBookingsData()
        {
            try
            {
                dataGridViewBookings.DataSource = adminManager.View_booking_datails();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings data: {ex.Message}");
            }
        }

        
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            int participantId = int.Parse(txtParticipantId.Text);
            int eventId = int.Parse(txtEventId.Text);

            try
            {
                adminManager.Add_booking_btn(participantId, eventId);  
                MessageBox.Show("Booking added successfully.");
                LoadBookingsData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding booking: {ex.Message}");
            }
        }

       
        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingId.Text))
            {
                MessageBox.Show("Please select a booking to update.");
                return;
            }

            int bookingId = Convert.ToInt32(txtBookingId.Text);
            int participantId = int.Parse(txtParticipantId.Text);
            int eventId = int.Parse(txtEventId.Text);

            try
            {
                adminManager.Update_booking_btn(bookingId, participantId, eventId); 
                MessageBox.Show("Booking updated successfully.");
                LoadBookingsData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating booking: {ex.Message}");
            }
        }

        
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingId.Text))
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int bookingId = Convert.ToInt32(txtBookingId.Text);
            var result = MessageBox.Show("Are you sure you want to delete this booking?", "Delete Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    adminManager.Delete_booking_btn(bookingId); 
                    MessageBox.Show("Booking deleted successfully.");
                    LoadBookingsData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting booking: {ex.Message}");
                }
            }
        }

        
        private void dataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBookings.Rows[e.RowIndex];
                txtBookingId.Text = row.Cells["booking_id"].Value.ToString();
                txtParticipantId.Text = row.Cells["participant_id"].Value.ToString();
                txtEventId.Text = row.Cells["event_id"].Value.ToString();
            }
        }

        
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantDashboardForm participantDashboard = new ParticipantDashboardForm();
            participantDashboard.Show();
            this.Hide();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnOrganizers_Click(object sender, EventArgs e)
        {
            OrganizerDashboardForm organizersDashboard = new OrganizerDashboardForm();
            organizersDashboard.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventDashboardForm eventsDashboard = new EventDashboardForm();
            eventsDashboard.Show();
            this.Hide();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already in Bookings Dashboard.");
        }

        private void BookingDashboardForm_Load(object sender, EventArgs e)
        {
            LoadBookingsData();
        }

        private void dataGridViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewBookings_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
