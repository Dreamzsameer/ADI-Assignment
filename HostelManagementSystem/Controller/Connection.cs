using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    class Connection
    {
        
        private static MySqlConnection databaseConnection = null;

        public static MySqlConnection GetConnection()
        {
            
            if (databaseConnection == null)
            {
                
                ConnectToDB();
            }
            return databaseConnection;
        }

        private static void ConnectToDB()
        {
            try
            {
                //connection string
                string mySqlConnectionString = "datasource=localhost;username=root;password=;database=hostelmanagementsystem;SSLmode=none";
                //getting connection
                databaseConnection = new MySqlConnection(mySqlConnectionString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Sorry, unable to connect to database!");
            }
        }


    }
}
