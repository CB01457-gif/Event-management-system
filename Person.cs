using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmanagement
{
    public abstract class Person
    {
        private string ID;
        private string Name;
        private string Email;
        private string NIC;
        private string Username;
        private string password;

     
        public string GetId() { return ID; }
        public void SetID(string id) { this.ID = id; }
        public string GetName() { return Name; }
        public void SetName(string name) { this.Name = name; }
        public string GetEmail() { return Email; }
        public void SetEmail(string email) { this.Email = email; }
        public string GetNIC() { return NIC; }
        public void SetNIC(string nic) { this.NIC = nic; }
        public string GetUsername() { return Username; }
        public void SetUsername(string username) { this.Username = username; }
        public string GetPassword() { return password; }
        public void SetPassword(string password) { this.password = password; }

      
        public Person(string id, string name, string email, string nic, string username, string password)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.NIC = nic;
            this.Username = username;
            this.password = password;
        }

        
       
    }
}
