using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class ParticipantDashboardForm : Form
    {
        private AdminManager adminManager;

        public ParticipantDashboardForm()
        {
            InitializeComponent();
            adminManager = new AdminManager();  
            LoadParticipantsData();   
            
          
           
        }

        
        private void LoadParticipantsData()
        {
            try
            {
                dataGridViewParticipants.DataSource = adminManager.View_participent_detail_btn();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                adminManager.Add_participant_btn(name, email, nic, username, password);  
                MessageBox.Show("Participant added successfully.");
                LoadParticipantsData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnUpdateParticipant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParticipantId.Text))
            {
                MessageBox.Show("Please select a participant from the list to update.");
                return;
            }

            int id = Convert.ToInt32(txtParticipantId.Text);  
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                adminManager.Update_participant_btn(id, name, email, nic, username, password);  
                MessageBox.Show("Participant updated successfully.");
                LoadParticipantsData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            if (dataGridViewParticipants.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(txtParticipantId.Text);  
                var result = MessageBox.Show("Are you sure you want to delete this participant?", "Delete Participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        adminManager.Remove_participant_btn(id);  
                        MessageBox.Show("Participant deleted successfully.");
                        LoadParticipantsData();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a participant to delete.");
            }
        }

        // Event handler for CellContentClick in DataGridView
        private void dataGridViewParticipants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewParticipants.Rows[e.RowIndex];

                txtParticipantId.Text = row.Cells["id"].Value.ToString();
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

       
        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingDashboardForm bookingDashboard = new BookingDashboardForm();
            bookingDashboard.Show();
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

        
        private void ParticipantDashboardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
