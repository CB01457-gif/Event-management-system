using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace eventmanagement
{
    public partial class LoginForm : Form
    {
        private PersonManager personManager;

        public LoginForm()
        {
            InitializeComponent();
            personManager = new PersonManager(); 
        }

        // handle login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // authenticate user using PersonManager
            string role = personManager.authentication(username, password);

            if (role == "Admin")
            {
                Admin admin = personManager.GetAdmin(username); // fetch admin from DB
                ParticipantDashboardForm participantDashboard = new ParticipantDashboardForm();
                participantDashboard.Show();
                this.Hide(); // hide login form
            }
            else if (role == "Organizer")
            {
                Organizer organizer = personManager.GetOrganizer(username); // Fetch organizer from DB
                OrganizerForm organizerForm = new OrganizerForm(organizer);
                organizerForm.Show();
                this.Hide(); // hide login form
            }
            else if (role == "Participant")
            {
                Participant participant = personManager.GetParticipant(username); // Fetch participant from DB
                ParticipantForm participantForm = new ParticipantForm(participant);
                participantForm.Show();
                this.Hide(); // hide login form
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // event handler for Sign-Up button click
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
