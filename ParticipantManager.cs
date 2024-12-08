using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public class ParticipantManager
    {
        private ParticipantForm participantForm;
        private Participant participant;
        private DbConnection db;

      
        public ParticipantManager(ParticipantForm form, Participant participant)
        {
            this.participantForm = form;
            this.participant = participant;
            db = new DbConnection();
        }

   
        public void LoadAvailableEvents()
        {
            var events = ViewAvailableEvents();
            participantForm.dgvEvents.Rows.Clear();

        
            if (participantForm.dgvEvents.Columns.Count == 0)
            {
                participantForm.dgvEvents.Columns.Add("Id", "Event ID");
                participantForm.dgvEvents.Columns.Add("Name", "Event Name");
                participantForm.dgvEvents.Columns.Add("EventType", "Event Type");
                participantForm.dgvEvents.Columns.Add("Venue", "Venue");
                participantForm.dgvEvents.Columns.Add("MaxParticipants", "Max Participants");
                participantForm.dgvEvents.Columns.Add("EventDate", "Event Date");
                participantForm.dgvEvents.Columns.Add("StartTime", "Start Time");
                participantForm.dgvEvents.Columns.Add("EndTime", "End Time");
            }

            foreach (var evnt in events)
            {
                participantForm.dgvEvents.Rows.Add(
                    evnt.getId(),
                    evnt.getEventName(),
                    evnt.getEventType(),
                    evnt.getVenue(),
                    evnt.getMaxParticipants(),
                    evnt.getEventDate().ToShortDateString(),
                    evnt.getStartTime().ToString(),
                    evnt.getEndTime().ToString()
                );
            }
        }

        // this function will load enrolled events and display them in  to the dataGridView
        public void LoadEnrolledEvents()
        {
            var events = ViewEnrolledEvents(participant.GetId());
            participantForm.dgvEvents.Rows.Clear();

            foreach (var evnt in events)
            {
                participantForm.dgvEvents.Rows.Add(
                    evnt.getId(),
                    evnt.getEventName(),
                    evnt.getEventType(),
                    evnt.getVenue(),
                    evnt.getMaxParticipants(),
                    evnt.getEventDate().ToShortDateString(),
                    evnt.getStartTime().ToString(),
                    evnt.getEndTime().ToString()
                );
            }
        }

        // this function will enroll the participant in an event
        public void EnrollForEvent(string eventId)
        {
            string message = EnrollForEventInDb(participant.GetId(), eventId);
            System.Windows.Forms.MessageBox.Show(message); 
            if (message.StartsWith("Success"))
            {
                LoadEnrolledEvents();
            }
        }

        // this function will  nenroll the participant  for the event
        public void UnenrollFromEvent(string eventId)
        {
            string message = UnenrollFromEventInDb(participant.GetId(), eventId);
            System.Windows.Forms.MessageBox.Show(message); 
            if (message.StartsWith("Success"))
            {
                LoadEnrolledEvents(); 
            }
        }

        // this function will show all the available events from the database
        private List<Event> ViewAvailableEvents()
        {
            List<Event> events = new List<Event>();
            db.OpenConnection();
            string query = "SELECT * FROM events";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                events.Add(new Event(
                    Convert.ToInt32(reader["id"]),
                    reader["name"].ToString(),
                    reader["event_type"].ToString(),
                    reader["venue"].ToString(),
                    Convert.ToInt32(reader["max_participants"]),
                    reader["organizer_id"].ToString(),
                    Convert.ToDateTime(reader["event_date"]),
                    TimeSpan.Parse(reader["start_time"].ToString()),
                    TimeSpan.Parse(reader["end_time"].ToString())
                ));
            }

            db.CloseConnection();
            return events;
        }

        // from this function the participant will be able to view enrolled events for a specific participant
        private List<Event> ViewEnrolledEvents(string participantId)
        {
            List<Event> events = new List<Event>();
            db.OpenConnection();
            string query = "SELECT e.* FROM events e JOIN bookings b ON e.id = b.event_id WHERE b.participant_id = @participantId";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@participantId", participantId);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                events.Add(new Event(
                    Convert.ToInt32(reader["id"]),
                    reader["name"].ToString(),
                    reader["event_type"].ToString(),
                    reader["venue"].ToString(),
                    Convert.ToInt32(reader["max_participants"]),
                    reader["organizer_id"].ToString(),
                    Convert.ToDateTime(reader["event_date"]),
                    TimeSpan.Parse(reader["start_time"].ToString()),
                    TimeSpan.Parse(reader["end_time"].ToString())
                ));
            }

            db.CloseConnection();
            return events;
        }

        // this function checks if the event exists
        private bool EventExists(string eventId)
        {
            db.OpenConnection();
            string query = "SELECT COUNT(*) FROM events WHERE id = @eventId";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@eventId", eventId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            db.CloseConnection();
            return count > 0;
        }

        // this function will check if the participant is already enrolled for the  event
        private bool IsParticipantEnrolled(string participantId, string eventId)
        {
            db.OpenConnection();
            string query = "SELECT COUNT(*) FROM bookings WHERE participant_id = @participantId AND event_id = @eventId";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@participantId", participantId);
            cmd.Parameters.AddWithValue("@eventId", eventId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            db.CloseConnection();
            return count > 0;
        }

        // enroll the participant in an event
     
        private string EnrollForEventInDb(string participantId, string eventId)
        {
           
            if (!EventExists(eventId))
            {
                return "Error: The event ID is invalid. Please check the event ID.";
            }

            if (IsParticipantEnrolled(participantId, eventId))
            {
                return "Error: You have already enrolled in this event.";
            }

            // this condition will check if the event has reached its maximum participants limit
            if (HasEventReachedMaxParticipants(eventId))
            {
                return "Error: This event has already reached its maximum number of participants. You cannot enroll.";
            }

            db.OpenConnection();
            string query = "INSERT INTO bookings (participant_id, event_id) VALUES (@participantId, @eventId)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@participantId", participantId);
            cmd.Parameters.AddWithValue("@eventId", eventId);
            int rowsAffected = cmd.ExecuteNonQuery();
            db.CloseConnection();

            return rowsAffected > 0 ? "Success: You have been enrolled in the event." : "Error: Enrollment failed. Please try again.";
        }
        // checks if the event has reached the maximum number of participants
        private bool HasEventReachedMaxParticipants(string eventId)
        {
            db.OpenConnection();

            // the query will  get the count of enrolled participants and the maximum number of participants  for the event
            string query = @"
        SELECT COUNT(b.participant_id) AS currentParticipants, e.max_participants
        FROM events e 
        LEFT JOIN bookings b ON e.id = b.event_id 
        WHERE e.id = @eventId";


            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@eventId", eventId);
            MySqlDataReader reader = cmd.ExecuteReader();

            int currentParticipants = 0;
            int maxParticipants = 0; 

            if (reader.Read())
            {
                currentParticipants = Convert.ToInt32(reader["currentParticipants"]);
                maxParticipants = Convert.ToInt32(reader["max_participants"]);
            }

            db.CloseConnection();

            // this will return true if current participants have reached or exceeded the maximum allowed
            return currentParticipants >= maxParticipants;
        }


        // fucton to enroll the participant from an event
        private string UnenrollFromEventInDb(string participantId, string eventId)
        {
           
            if (!EventExists(eventId))
            {
                return "Error: The event ID is invalid. Please check the event ID.";
            }

            // Check if the participant is enrolled in the event
            if (!IsParticipantEnrolled(participantId, eventId))
            {
                return "Error: You are not enrolled in this event.";
            }

            db.OpenConnection();
            string query = "DELETE FROM bookings WHERE participant_id = @participantId AND event_id = @eventId";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@participantId", participantId);
            cmd.Parameters.AddWithValue("@eventId", eventId);
            int rowsAffected = cmd.ExecuteNonQuery();
            db.CloseConnection();

            return rowsAffected > 0 ? "Success: You have been unenrolled from the event." : "Error: Unenrollment failed. Please try again.";
        }

        //this method will register a user as a participant
        public void register_btn(string name, string email, string nic, string username, string password)
        {
            
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(nic) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error: All fields must be filled in.");
                return;
            }

            try
            {
                // check if the name, email, or NIC already exists
                if (IsNameEmailOrNICTaken(name, email, nic))
                {
                    MessageBox.Show("Error: The name, email, or NIC is already taken. Please choose a different one.");
                    return;
                }

                db.OpenConnection();
                string query = "INSERT INTO participants (name, email, nic, username, password) VALUES (@Name, @Email, @Nic, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Participant registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // method to check if the name, email, or NIC is already taken
        private bool IsNameEmailOrNICTaken(string name, string email, string nic)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(*) FROM participants WHERE name = @Name OR email = @Email OR nic = @Nic";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                db.CloseConnection();

                // if the  count is greater than 0, it means the name, email, or NIC already exists
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


    }
}
