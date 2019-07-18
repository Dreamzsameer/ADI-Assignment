using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    class User
    {
        string firstName, lastName, username, password;
        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string value)
        {
            this.firstName= value;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string value)
        {
            this.lastName = value;
        }
        public string getUsername()
        {
            return this.username;
        }

        public void setUsername(string value)
        {
            this.username = value;
        }
        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string value)
        {
            this.password = value;
        }
    }
}
