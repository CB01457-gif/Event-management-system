using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmanagement
{
    public class PersonManager
    {
        private DbConnection db;

        public PersonManager()
        {
            db = new DbConnection();
        }

      
        

     
        private bool Login(string role, string username, string password)
        {
            bool isValid = false;
            try
            {
                db.OpenConnection();
                string query = $"SELECT * FROM {role} WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                isValid = reader.HasRows; 
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return isValid;
        }
        public string authentication(string username, string password)
        {
            string role = null;

            // check the Admin table
            if (Login("admins", username, password))
            {
                role = "Admin";
            }
            // check  the Organizer table
            else if (Login("organizers", username, password))
            {
                role = "Organizer";
            }
            // check the Participant table
            else if (Login("participants", username, password))
            {
                role = "Participant";
            }

            return role;
        }
        // this method to fetch Admin details from the database
        public Admin GetAdmin(string username)
        {
            Admin admin = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM admins WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    admin = new Admin(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["username"].ToString(),
                        reader["email"].ToString(),
                        reader["nic"].ToString(),
                        reader["password"].ToString()
                    );
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return admin;
        }

        // method to fetch Organizer details from the database
        public Organizer GetOrganizer(string username)
        {
            Organizer organizer = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM organizers WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    organizer = new Organizer(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["username"].ToString(),
                        reader["email"].ToString(),
                        reader["nic"].ToString(),
                        reader["password"].ToString()
                    );
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return organizer;
        }

        // method to fetch Participant details from the database
        public Participant GetParticipant(string username)
        {
            Participant participant = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM participants WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    participant = new Participant(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["username"].ToString(),
                        reader["email"].ToString(),
                        reader["nic"].ToString(),
                        reader["password"].ToString()
                    );
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return participant;
        }
    }
}

