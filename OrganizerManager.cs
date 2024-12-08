using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public class OrganizerManager
    {
        private OrganizerForm organizerForm;
        private Organizer organizer;
        private DbConnection db;

        public OrganizerManager(OrganizerForm form, Organizer organizer)
        {
            this.organizerForm = form;
            this.organizer = organizer;
            this.db = new DbConnection();  
        }

        // View created events
        public void View_created_events_btn()
        {
            List<Event> events = new List<Event>();

            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Events WHERE organizer_id = @organizerId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@organizerId", organizer.GetId());

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime eventDate = Convert.ToDateTime(reader["event_date"]);
                        TimeSpan startTime = TimeSpan.Parse(reader["start_time"].ToString());
                        TimeSpan endTime = TimeSpan.Parse(reader["end_time"].ToString());

                        events.Add(new Event(
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["event_type"].ToString(),
                            reader["venue"].ToString(),
                            Convert.ToInt32(reader["max_participants"]),
                            reader["organizer_id"].ToString(),
                            eventDate,
                            startTime,
                            endTime
                        ));
                    }
                }

                db.CloseConnection();

                if (events.Count > 0)
                {
                    organizerForm.ClearDataGridView();
                    foreach (var ev in events)
                    {
                        organizerForm.AddRowToCreatedEvents(
                            ev.getId().ToString(),
                            ev.getEventName(),
                            ev.getEventType(),
                            ev.getVenue(),
                            ev.getMaxParticipants(),
                            ev.getEventDate(),  
                            ev.getStartTime(),  
                            ev.getEndTime()     
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No events found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving events: {ex.Message}");
                db.CloseConnection();
            }
        }

        // Create a new event
        public void Create_event_btn(string eventName, string eventType, string venue, string maxParticipantsInput, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
              
                if (!int.TryParse(maxParticipantsInput, out int maxParticipants) || maxParticipants <= 0)
                {
                    MessageBox.Show("Error: Max Participants must be a valid positive number.");
                    return; // stop execution if maxParticipants is invalid
                }

               
                if (eventDate < DateTime.Now.Date)
                {
                    MessageBox.Show("Error: The event date cannot be in the past.");
                    return; 
                }

                
                if (startTime >= endTime)
                {
                    MessageBox.Show("Error: The start time must be earlier than the end time.");
                    return; 
                }

                db.OpenConnection();
                string query = "INSERT INTO Events (organizer_id, name, event_type, venue, max_participants, event_date, start_time, end_time) " +
                               "VALUES (@organizerId, @eventName, @eventType, @venue, @maxParticipants, @eventDate, @startTime, @endTime)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@organizerId", organizer.GetId());
                cmd.Parameters.AddWithValue("@eventName", eventName);
                cmd.Parameters.AddWithValue("@eventType", eventType);
                cmd.Parameters.AddWithValue("@venue", venue);
                cmd.Parameters.AddWithValue("@maxParticipants", maxParticipants);  
                cmd.Parameters.AddWithValue("@eventDate", eventDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@startTime", startTime.ToString());
                cmd.Parameters.AddWithValue("@endTime", endTime.ToString());
                cmd.ExecuteNonQuery();

                db.CloseConnection();
                MessageBox.Show("Event created successfully!");
                View_created_events_btn();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating event: {ex.Message}");
                db.CloseConnection();  
            }
        }


        // Update an existing event
        public void Update_event_btn(string eventId, string eventName, string eventType, string venue, string maxParticipantsInput, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
{
    try
    {
        // Validate eventId
        if (string.IsNullOrWhiteSpace(eventId))
        {
            MessageBox.Show("Error: Event ID is required.");
            return; // Stop execution if eventId is invalid
        }

     
        if (!int.TryParse(maxParticipantsInput, out _))
        {
            MessageBox.Show("Error: Max Participants must be a valid number.");
            return; 
        }

    
        if (eventDate < DateTime.Now.Date)
        {
            MessageBox.Show("Error: The event date cannot be in the past.");
            return; // stop execution if the date is invalid
        }

        // validate that the start time is earlier than the end time
        if (startTime >= endTime)
        {
            MessageBox.Show("Error: The start time must be earlier than the end time.");
            return; // Stop execution if the times are invalid
        }

        db.OpenConnection();
        string query = "UPDATE Events SET name = @eventName, event_type = @eventType, venue = @venue, max_participants = @maxParticipantsInput, " +
                       "event_date = @eventDate, start_time = @startTime, end_time = @endTime WHERE id = @eventId";
        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
        cmd.Parameters.AddWithValue("@eventId", eventId);
        cmd.Parameters.AddWithValue("@eventName", eventName);
        cmd.Parameters.AddWithValue("@eventType", eventType);
        cmd.Parameters.AddWithValue("@venue", venue);
        cmd.Parameters.AddWithValue("@maxParticipantsInput", maxParticipantsInput);  // Use the string directly as input
        cmd.Parameters.AddWithValue("@eventDate", eventDate.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@startTime", startTime.ToString());
        cmd.Parameters.AddWithValue("@endTime", endTime.ToString());
        cmd.ExecuteNonQuery();

        db.CloseConnection();
        MessageBox.Show("Event updated successfully!");
        View_created_events_btn();  // Refresh the event list
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error updating event: {ex.Message}");
        db.CloseConnection();  // Ensure connection is closed on error
    }
}



        // Delete an event
        public void Delete_event_btn(string eventId)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM Events WHERE id = @eventId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@eventId", eventId);
                cmd.ExecuteNonQuery();

                db.CloseConnection();
                MessageBox.Show("Event deleted successfully!");
                View_created_events_btn();  // Refresh the event list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting event: {ex.Message}");
                db.CloseConnection();  // Ensure connection is closed on error
            }
        }

        // View participants for selected event
        public void View_enrolled_participants(string eventId)
        {
            List<Participant> participants = new List<Participant>();

            try
            {
                db.OpenConnection();
                string query = @"SELECT p.id,p.name, p.username, p.email 
                                 FROM Participants p
                                 JOIN bookings b ON p.id = b.participant_id
                                 WHERE b.event_id = @eventId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@eventId", eventId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        participants.Add(new Participant(
                            reader["id"].ToString(),
                            reader["name"].ToString(),
                            reader["email"].ToString(),
                            "",  
                            reader["username"].ToString(),
                            ""  
                        ));
                    }
                }

                db.CloseConnection();

                if (participants.Count > 0)
                {
                    organizerForm.ClearParticipantsDataGridView();  
                    foreach (var participant in participants)
                    {
                        organizerForm.AddRowToParticipants(
                            participant.GetId().ToString(),
                            participant.GetUsername(),
                            participant.GetEmail()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No participants found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving participants: {ex.Message}");
                db.CloseConnection();  
            }
        }
    }
}
