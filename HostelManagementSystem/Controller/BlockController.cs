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
    class BlockController
    {
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        public BlockController() {

            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }

        }
        public Boolean AddBlock(BlockBuilding block)
        {
            Boolean userAdded = false;
            string query = "insert into tblblock (name, gender, description,status)" +
                "values ('" + block.getBlockName() + "', '" + block.getGender()+ "', '" + block.getDescription() + "', '" + block.getStatus() + "')";
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
        public BlockBuilding SearchBlock(string search)
        {
            BlockBuilding block = new BlockBuilding();
            string query = "select * from tblblock where blockId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    block.setBlockId(reader["blockId"].ToString());
                    block.setBlockName(reader["name"].ToString());
                    block.setGender(reader["gender"].ToString());
                    block.setDescription(reader["description"].ToString());
                    block.setStatus(reader["status"].ToString());



                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return block;
        }
        public Boolean UpdateBlock(BlockBuilding block)
        {
            Boolean isUpdated = false;
            string query = "update tblblock set name='" + block.getBlockName() + "', " +
                "gender='" + block.getGender() + "'," +
                "description='" + block.getDescription() + "'," +
                "status='" + block.getStatus() + "'where blockId='" + block.getBlockId() + "';";
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
        public Boolean DeleteBlock(string id)
        {
            Boolean courseDeleted = false;
            string query = "delete from tblblock where blockid='" + id + "'";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    courseDeleted = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return courseDeleted;
        }
    }
}
