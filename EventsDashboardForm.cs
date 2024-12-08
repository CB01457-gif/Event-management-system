using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class EventDashboardForm : Form
    {
        private AdminManager adminManager = new AdminManager();  

        public EventDashboardForm()
        {
            InitializeComponent();
            LoadEventsData();  
        }

        // Method to load events data into DataGridView
        private void LoadEventsData()
        {
            try
            {
                dataGridViewEvents.DataSource = adminManager.View_all_events_btn();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Add Event button click
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string eventType = txtEventType.Text;
            string venue = txtVenue.Text;
            int maxParticipants = int.Parse(txtMaxParticipants.Text);
            int organizerId = int.Parse(txtOrganizerId.Text);
            DateTime eventDate = DateTime.Parse(txtEventDate.Text);
            TimeSpan startTime = TimeSpan.Parse(txtStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);

            try
            {
                adminManager.Create_event_btn(name, eventType, venue, maxParticipants, organizerId, eventDate, startTime, endTime);  // Use AdminController to add event
                MessageBox.Show("Event added successfully.");
                LoadEventsData();  // Reload events data after adding
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Update Event button click
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an event from the list to update.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string eventType = txtEventType.Text;
            string venue = txtVenue.Text;
            int maxParticipants = int.Parse(txtMaxParticipants.Text);
            int organizerId = int.Parse(txtOrganizerId.Text);
            DateTime eventDate = DateTime.Parse(txtEventDate.Text);
            TimeSpan startTime = TimeSpan.Parse(txtStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);

            try
            {
                adminManager.Update_event_btn(id, name, eventType, venue, maxParticipants, organizerId, eventDate, startTime, endTime);  // Use AdminController to update event
                MessageBox.Show("Event updated successfully.");
                LoadEventsData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Delete Event button click
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var result = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    adminManager.Delete_event_btn(id); 
                    MessageBox.Show("Event deleted successfully.");
                    LoadEventsData();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Event handler for CellContentClick in DataGridView
        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEventType.Text = row.Cells["event_type"].Value.ToString();
                txtVenue.Text = row.Cells["venue"].Value.ToString();
                txtMaxParticipants.Text = row.Cells["max_participants"].Value.ToString();
                txtOrganizerId.Text = row.Cells["organizer_id"].Value.ToString();
                txtEventDate.Text = DateTime.Parse(row.Cells["event_date"].Value.ToString()).ToString("yyyy-MM-dd");
                txtStartTime.Text = TimeSpan.Parse(row.Cells["start_time"].Value.ToString()).ToString(@"hh\:mm\:ss");
                txtEndTime.Text = TimeSpan.Parse(row.Cells["end_time"].Value.ToString()).ToString(@"hh\:mm\:ss");
            }
        }

        // Event handler for Participants button click
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantDashboardForm participantDashboard = new ParticipantDashboardForm();
            participantDashboard.Show();
            this.Hide();
        }

        // Event handler for Admins button click
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm();
            adminDashboard.Show();
            this.Hide();
        }

        // Event handler for Organizers button click
        private void btnOrganizers_Click(object sender, EventArgs e)
        {
            OrganizerDashboardForm organizersDashboard = new OrganizerDashboardForm();
            organizersDashboard.Show();
            this.Hide();
        }

        // Event handler for Events button click
        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventDashboardForm eventsDashboard = new EventDashboardForm();
            eventsDashboard.Show();
            this.Hide();
        }

        // Event handler for Bookings button click
        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingDashboardForm bookingDashboard = new BookingDashboardForm();
            bookingDashboard.Show();
            this.Hide();
        }

        private void EventDashboardForm_Load(object sender, EventArgs e)
        {
         
        }

        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
