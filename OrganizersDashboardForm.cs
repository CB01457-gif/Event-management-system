using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class OrganizerDashboardForm : Form
    {
        private AdminManager adminManager= new AdminManager();  // Use AdminController to manage organizers

        public OrganizerDashboardForm()
        {
            InitializeComponent();
            LoadOrganizersData();  // Load organizers data when the form loads
        }

        // Method to load organizers data into DataGridView
        private void LoadOrganizersData()
        {
            try
            {
                dataGridViewOrganizers.DataSource = adminManager.View_organizers_details_btn();  // Use AdminController to get data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Add Organizer button click
        private void btnAddOrganizer_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                adminManager.Add_Organizer_btn(name, email, nic, username, password);  // Use AdminController to add organizer
                MessageBox.Show("Organizer added successfully.");
                LoadOrganizersData();  // Reload organizers data after adding
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Update Organizer button click
        private void btnUpdateOrganizer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an organizer from the list to update.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                adminManager.Update_Organizer_btn(id, name, email, nic, username, password);  // Use AdminController to update organizer
                MessageBox.Show("Organizer updated successfully.");
                LoadOrganizersData();  // Reload organizers data after updating
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for Delete Organizer button click
        private void btnDeleteOrganizer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an organizer to delete.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var result = MessageBox.Show("Are you sure you want to delete this organizer?", "Delete Organizer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    adminManager.Remove_Organizer_btn(id);  // Use AdminController to delete organizer
                    MessageBox.Show("Organizer deleted successfully.");
                    LoadOrganizersData();  // Reload organizers data after deletion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Event handler for CellContentClick in DataGridView
        private void dataGridViewOrganizers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrganizers.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtNic.Text = row.Cells["nic"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
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

        private void OrganizerDashboardForm_Load(object sender, EventArgs e)
        {
            // Optional: Any additional logic when the form loads
        }

        private void dataGridViewOrganizers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Any additional logic when the cell content is clicked
        }

        private void btnLogout_Click_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
