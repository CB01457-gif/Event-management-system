using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public class AdminManager
    {
        private DbConnection db;

        public AdminManager()
        {
            db = new DbConnection(); 
        }

        //  get  participants from the database
        public DataTable View_participent_detail_btn()
        {
            DataTable table = new DataTable();

            try
            {
                db.OpenConnection();
                string query = "SELECT id, name, email, nic, username, password FROM participants"; 
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading participants data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return table;  
        }

        //  add a participant to the database
        public void Add_participant_btn(string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO participants (name, email, nic, username, password) VALUES (@Name, @Email, @Nic, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding participant: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  update a participant in the database
        public void Update_participant_btn(int id, string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE participants SET name = @Name, email = @Email, nic = @Nic, username = @Username, password = @Password WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating participant: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  delete a participant from the database
        public void Remove_participant_btn(int id)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM participants WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting participant: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public DataTable View_admins_details_btn()
        {
            DataTable table = new DataTable();
            try
            {
                db.OpenConnection();
                string query = "SELECT id, name, email, nic, username, password FROM admins";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading admin data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
            return table;
        }

        // add an admin to the database
        public void Add_Admin_btn(string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO admins (name, email, nic, username, password) VALUES (@Name, @Email, @Nic, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding admin: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  update an admin in the database
        public void Update_Admin_btn(int id, string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE admins SET name = @Name, email = @Email, nic = @Nic, username = @Username, password = @Password WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating admin: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  delete an admin from the database
        public void Remove_Admin_btn(int id)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM admins WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting admin: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public DataTable View_organizers_details_btn()
        {
            DataTable table = new DataTable();
            try
            {
                db.OpenConnection();
                string query = "SELECT id, name, email, nic, username, password FROM organizers";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading organizers data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
            return table;
        }

        //  add organizer to the database
        public void Add_Organizer_btn(string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO organizers (name, email, nic, username, password) VALUES (@Name, @Email, @Nic, @Username, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding organizer: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // update an organizer in the database
        public void Update_Organizer_btn(int id, string name, string email, string nic, string username, string password)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE organizers SET name = @Name, email = @Email, nic = @Nic, username = @Username, password = @Password WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating organizer: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  delete an organizer from the database
        public void Remove_Organizer_btn(int id)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM organizers WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting organizer: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public DataTable View_all_events_btn()
        {
            DataTable table = new DataTable();
            try
            {
                db.OpenConnection();
                string query = "SELECT id, name, event_type, venue, max_participants, organizer_id, event_date, start_time, end_time FROM events";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading events data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
            return table;
        }

        // add an event to the database
        public void Create_event_btn(string name, string eventType, string venue, int maxParticipants, int organizerId, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO events (name, event_type, venue, max_participants, organizer_id, event_date, start_time, end_time) " +
                               "VALUES (@Name, @EventType, @Venue, @MaxParticipants, @OrganizerId, @EventDate, @StartTime, @EndTime)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@EventType", eventType);
                cmd.Parameters.AddWithValue("@Venue", venue);
                cmd.Parameters.AddWithValue("@MaxParticipants", maxParticipants);
                cmd.Parameters.AddWithValue("@OrganizerId", organizerId);
                cmd.Parameters.AddWithValue("@EventDate", eventDate);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding event: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }



        //  update an event in the database
        public void Update_event_btn(int id, string name, string eventType, string venue, int maxParticipants, int organizerId, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE events SET name = @Name, event_type = @EventType, venue = @Venue, " +
                               "max_participants = @MaxParticipants, organizer_id = @OrganizerId, event_date = @EventDate, " +
                               "start_time = @StartTime, end_time = @EndTime WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@EventType", eventType);
                cmd.Parameters.AddWithValue("@Venue", venue);
                cmd.Parameters.AddWithValue("@MaxParticipants", maxParticipants);
                cmd.Parameters.AddWithValue("@OrganizerId", organizerId);
                cmd.Parameters.AddWithValue("@EventDate", eventDate);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating event: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // delete an event from the database
        public void Delete_event_btn(int id)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM events WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting event: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public DataTable View_booking_datails()
        {
            DataTable table = new DataTable();
            try
            {
                db.OpenConnection();
                string query = "SELECT booking_id, participant_id, event_id FROM bookings";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading bookings data: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
            return table;
        }

        //  add a booking to the database
        public void Add_booking_btn(int participantId, int eventId)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO bookings (participant_id, event_id) VALUES (@ParticipantId, @EventId)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@ParticipantId", participantId);
                cmd.Parameters.AddWithValue("@EventId", eventId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding booking: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // update a booking in the database
        public void Update_booking_btn(int bookingId, int participantId, int eventId)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE bookings SET participant_id = @ParticipantId, event_id = @EventId WHERE booking_id = @BookingId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@BookingId", bookingId);
                cmd.Parameters.AddWithValue("@ParticipantId", participantId);
                cmd.Parameters.AddWithValue("@EventId", eventId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating booking: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        //  delete a booking from the database
        public void Delete_booking_btn(int bookingId)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM bookings WHERE booking_id = @BookingId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@BookingId", bookingId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting booking: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}



