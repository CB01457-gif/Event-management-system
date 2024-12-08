using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eventmanagement
{
    public class Participant : Person 
    {
        private DbConnection db;

        public Participant(string id,string name, string email, string nic, string username, string password)
            : base(id, name,email, nic, username, password)
        {
            db = new DbConnection();
        }

       
    }
}

