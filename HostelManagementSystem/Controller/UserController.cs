using HostelManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem.Controller
{
    class UserController
{
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        public UserController() {
            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }
        }
        public Boolean Authenticate(User user)
        {
            Boolean isValid = false;
            string query = "select * from tbluser where username='" + user.getUsername() + "' " +
                "and password='" + user.getPassword() + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    isValid = true;
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return isValid;
        }
        public Boolean AddUser(User user)
        {
            Boolean userAdded = false;
            string query = "insert into tbluser (firstName, lastName, username, password)" +
                "values ('" + user.getFirstName() + "', '" + user.getLastName() + "', '" + user.getUsername() + "', '" + user.getPassword() + "');";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    userAdded = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return userAdded;
        }

    }
}
