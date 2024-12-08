using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmanagement
{
    public partial class ParticipantForm : Form
    {
        private Participant participant;
        private ParticipantManager participantManager;

        public ParticipantForm(Participant participant)
        {
            InitializeComponent();
            this.participant = participant;
            participantManager = new ParticipantManager(this, participant);
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {participant.GetUsername()}!";
        }

        private void btnViewAllEvents_Click(object sender, EventArgs e)
        {
            participantManager.LoadAvailableEvents();
        }

        private void btnViewEnrolledEvents_Click(object sender, EventArgs e)
        {
            participantManager.LoadEnrolledEvents();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string eventId = txtEnrollEventId.Text.Trim();
            participantManager.EnrollForEvent(eventId);
        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            string eventId = txtEnrollEventId.Text.Trim();
            participantManager.UnenrollFromEvent(eventId);
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
