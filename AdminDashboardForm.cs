using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public partial class AdminDashboardForm : Form
    {
        private AdminManager adminManager = new AdminManager();  

        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadAdminData();         
        }

        //  load admin data into DataGridView
        private void LoadAdminData()
        {
            try
            {
                dataGridViewAdmin.DataSource = adminManager.View_admins_details_btn();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                adminManager.Add_Admin_btn(name, email, nic, username, password); 
                MessageBox.Show("Admin added successfully.");
                LoadAdminData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an admin from the list to update.");
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
                adminManager.Update_Admin_btn(id, name, email, nic, username, password);  
                MessageBox.Show("Admin updated successfully.");
                LoadAdminData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please select an admin to delete.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var result = MessageBox.Show("Are you sure you want to delete this admin?", "Delete Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    adminManager.Remove_Admin_btn(id);  
                    MessageBox.Show("Admin deleted successfully.");
                    LoadAdminData();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dataGridViewAdmin.Rows[e.RowIndex];

               
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtNic.Text = row.Cells["nic"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
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
            BookingDashboardForm bookingDashboard = new BookingDashboardForm();
            bookingDashboard.Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
