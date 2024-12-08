using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    internal class DbConnection
    {
        private string server;
        private string database;
        private string user;
        private string password;
        private MySqlConnection connection;

        public DbConnection()
        {
           
            server = "localhost";
            database = "event_management_db"; 
            user = "root"; 
            password = ""; 

            // Create the connection string
            string connectionString = $"server={server};database={database};user={user};password={password};";
            connection = new MySqlConnection(connectionString);
        }

        // Method to open the connection
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Method to close the connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Method to get the current connection object
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
