using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            // Do not initialize ParticipantManager here since it requires specific parameters
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Collect user input values
            string name = txtName.Text;
            string email = txtEmail.Text;
            string nic = txtNic.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

          
            Participant participant = new Participant("", name, email, nic, username, password);

            ParticipantForm participantForm = new ParticipantForm(participant);

            ParticipantManager participantManager = new ParticipantManager(participantForm, participant);

           
            participantManager.register_btn(name, email, nic, username, password);
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }
    }
}
