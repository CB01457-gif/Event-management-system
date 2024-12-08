using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class OrganizerForm : Form
    {
        private OrganizerManager organizerManager;

        public OrganizerForm(Organizer organizer)
        {
            InitializeComponent();
            organizerManager = new OrganizerManager(this, organizer);
            lblWelcome.Text = $"Welcome, {organizer.GetUsername()}!";
            dgvCreatedEvents.CellClick += dgvCreatedEvents_CellClick;
        }

        public void ClearDataGridView()
        {
            dgvCreatedEvents.Rows.Clear();
            dgvCreatedEvents.Columns.Clear();
        }

        public void ClearParticipantsDataGridView()
        {
            dgvCreatedEvents.Rows.Clear();
            dgvCreatedEvents.Columns.Clear();
        }

        public void AddRowToCreatedEvents(string eventId, string eventName, string eventType, string venue, int maxParticipants, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            if (dgvCreatedEvents.Columns.Count == 0)
            {
                dgvCreatedEvents.Columns.Add("EventID", "Event ID");
                dgvCreatedEvents.Columns.Add("EventName", "Event Name");
                dgvCreatedEvents.Columns.Add("EventType", "Event Type");
                dgvCreatedEvents.Columns.Add("Venue", "Venue");
                dgvCreatedEvents.Columns.Add("MaxParticipants", "Max Participants");
                dgvCreatedEvents.Columns.Add("EventDate", "Event Date");
                dgvCreatedEvents.Columns.Add("StartTime", "Start Time");
                dgvCreatedEvents.Columns.Add("EndTime", "End Time");
            }

            dgvCreatedEvents.Rows.Add(eventId, eventName, eventType, venue, maxParticipants,
                eventDate.ToShortDateString(), startTime.ToString(), endTime.ToString());
        }

        public void AddRowToParticipants(string participantId, string name, string email)
        {
            if (dgvCreatedEvents.Columns.Count == 0)
            {
                dgvCreatedEvents.Columns.Add("ParticipantID", "Participant ID");
                dgvCreatedEvents.Columns.Add("Name", "Name");
                dgvCreatedEvents.Columns.Add("Email", "Email");
            }

            dgvCreatedEvents.Rows.Add(participantId, name, email);
        }

        private void btnViewCreatedEvents_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            organizerManager.View_created_events_btn();
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedCreatedEventRow();

            if (selectedRow != null)
            {
                string eventId = selectedRow.Cells["EventID"].Value.ToString();

                ClearParticipantsDataGridView();

                organizerManager.View_enrolled_participants(eventId);
            }
            else
            {
                MessageBox.Show("Please select the row to see the participants who have enrolled.");
            }
        }

        private string selectedEventId = null;

        private void dgvCreatedEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCreatedEvents.Rows[e.RowIndex];

                selectedEventId = selectedRow.Cells["EventID"].Value.ToString();

                txtEventName.Text = selectedRow.Cells["EventName"].Value.ToString();
                txtEventType.Text = selectedRow.Cells["EventType"].Value.ToString();
                txtVenue.Text = selectedRow.Cells["Venue"].Value.ToString();
                txtMaxParticipants.Text = selectedRow.Cells["MaxParticipants"].Value.ToString();
                dtpEventDate.Value = DateTime.Parse(selectedRow.Cells["EventDate"].Value.ToString());
                dtpStartTime.Value = DateTime.Parse(selectedRow.Cells["StartTime"].Value.ToString());
                dtpEndTime.Value = DateTime.Parse(selectedRow.Cells["EndTime"].Value.ToString());
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (selectedEventId != null)
            {
                string eventName = txtEventName.Text;
                string eventType = txtEventType.Text;
                string venue = txtVenue.Text;
                string maxParticipants = txtMaxParticipants.Text;
                DateTime eventDate = dtpEventDate.Value;
                TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
                TimeSpan endTime = dtpEndTime.Value.TimeOfDay;

                organizerManager.Update_event_btn(selectedEventId, eventName, eventType, venue, maxParticipants, eventDate, startTime, endTime);

                organizerManager.View_created_events_btn();

                MessageBox.Show("Event updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select an event to update.");
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedCreatedEventRow();
            if (selectedRow != null)
            {
                string eventId = selectedRow.Cells["EventID"].Value.ToString();
                organizerManager.Delete_event_btn(eventId);
            }
            else
            {
                MessageBox.Show("Please select an event to delete.");
            }
        }

        public DataGridViewRow GetSelectedCreatedEventRow()
        {
            if (dgvCreatedEvents.SelectedRows.Count > 0)
            {
                return dgvCreatedEvents.SelectedRows[0];
            }
            return null;
        }

        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            organizerManager.View_created_events_btn();
        }

        private void dgvCreatedEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLogout_Click_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string eventType = txtEventType.Text;
            string venue = txtVenue.Text;
            string maxParticipantsInput = txtMaxParticipants.Text;
            DateTime eventDate = dtpEventDate.Value;
            TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
            TimeSpan endTime = dtpEndTime.Value.TimeOfDay;

            organizerManager.Create_event_btn(eventName, eventType, venue, maxParticipantsInput, eventDate, startTime, endTime);

            
            organizerManager.View_created_events_btn();
        }
    }
}
