using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagementSystem
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;

        public Connection() {
           
        }
        private void Initialie()
        {

            server = "localhost";
            database = "hostelmanagementsystem";
            username = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

        }
    }
}
