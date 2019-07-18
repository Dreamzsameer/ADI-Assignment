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
    class RoomController
    {
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        public RoomController() {
            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }
        }
        public Boolean AddRoom(Room room)
        {
            Boolean userAdded = false;
            string query = "insert into tblroom (roomNumber, numberOfBeds, description,status, block, fee)" +
                "values ('" + room.getRoomNumber() + "', '" + room.getNumberOfBeds() + "', '" + room.getDescription()+ "','" + room.getStatus() + "','" + room.getBlock() + "', '" + room.getFee() + "')";
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
        public Room SearchRoom(string search)
        {
            Room room = new Room();
            string query = "select * from tblroom where roomId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    room.setRoomId(reader["roomId"].ToString());
                    room.setRoomNumber(reader["roomNumber"].ToString());
                    room.setNumberOfBeds(reader["numberOfBeds"].ToString());
                    room.setDescription(reader["description"].ToString());
                    room.setStatus(reader["status"].ToString());
                    room.setBlock(reader["block"].ToString());
                    room.setFee(reader["fee"].ToString());
                    
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return room;
        }
        public Boolean UpdateRoom(Room room, string search)
        {
            Boolean isUpdated = false;
            string query = "update tblroom set roomNumber='" + room.getRoomNumber() + "', " +
                "numberOfBeds='" + room.getNumberOfBeds() + "'," +
                "description='" + room.getDescription() + "', status='" + room.getStatus() + "', " +
                "block='" + room.getBlock() + "' , "+ "fee = '" + room.getFee() + "'where roomId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int updatedRow = commandDatabase.ExecuteNonQuery();
                if (updatedRow > 0)
                {
                    isUpdated = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return isUpdated;
        }
        public Boolean DeleteRoom(string id)
        {
            Boolean roomDeleted = false;
            string query = "delete from tblroom where roomId='" + id + "'";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    roomDeleted = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return roomDeleted;
        }
    }
}
