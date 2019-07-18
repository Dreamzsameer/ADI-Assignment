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
    class StaffController
    {
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;

        public StaffController() {
            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }
        }
        public Boolean AddStaff(Staff staff)
        {
            Boolean userAdded = false;
            string query = "insert into tblstaff (name, address, DOB, gender, contactNumber, bloodGroup, fatherName, motherName, pContactNumber, designation, block, status)" +
                "values ('" + staff.getName() + "', '" + staff.getAddress() + "', '" + staff.getDOB() + "', '" + staff.getGender() + "','" + staff.getContactNumber() + "','" + staff.getBloodGroup() + "','" + staff.getFatherName() + "','" + staff.getMotherName() + "','" + staff.getPContactNumber() + "','" + staff.getDesignation() + "','" + staff.getBlock() + "','" + staff.getStatus() + "');";
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
        public Staff SearchStaff(string search)
        {
            Staff staff = new Staff();
            string query = "select * from tblstaff where staffId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    staff.setId(reader["staffId"].ToString());
                    staff.setName(reader["name"].ToString());
                    staff.setAddress(reader["address"].ToString());
                    staff.setGender(reader["gender"].ToString());
                    staff.setDOB(reader["DOB"].ToString());
                    staff.setContactNumber(reader["contactNumber"].ToString());
                    staff.setBloodGroup(reader["bloodGroup"].ToString());
                    staff.setFatherName(reader["fatherName"].ToString());
                    staff.setMotherName(reader["motherName"].ToString());
                    staff.setPContactNumber(reader["pContactNumber"].ToString());
                    staff.setDesignation(reader["designation"].ToString());
                    staff.setBlock(reader["block"].ToString());
                    staff.setStatus(reader["status"].ToString());
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return staff;
        }
        public Boolean UpdateStaff(Staff staff, string search)
        {
            Boolean isUpdated = false;
            string query = "update tblstaff set name='" + staff.getName() + "', " +
                "address='" + staff.getAddress() + "'," +
                "gender='" + staff.getGender() + "', DOB='" + staff.getDOB() + "', " +
                "contactNumber='" + staff.getContactNumber() + "', bloodGroup='" + staff.getBloodGroup() + "',fatherName='" + staff.getFatherName() + "',motherName='" + staff.getMotherName() + "',pContactNumber='" + staff.getPContactNumber() + "',designation='" + staff.getCourse() + "',block='" + staff.getBlock() + "',status='" + staff.getStatus() + "' where staffId='" + search + "';";
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
        public Boolean DeleteStaff(string id)
        {
            Boolean userDeleted = false;
            string query = "delete from tblStaff where staffId='" + id + "'";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    userDeleted = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return userDeleted;
        }
    }
}
