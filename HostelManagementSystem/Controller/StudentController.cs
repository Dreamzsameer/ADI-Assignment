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
    class StudentController
    { 
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        public StudentController()
        {
            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }
        }

        public Boolean AddStudent(Student student)
        {
            Boolean userAdded = false;
            string query = "insert into tblstudent (name, address, DOB, gender, contactNumber, bloodGroup, fatherName, motherName, pContactNumber, course, block, status)" +
                "values ('" + student.getName() + "', '" + student.getAddress() + "', '" + student.getDOB() + "', '" + student.getGender() + "','" + student.getContactNumber() + "','" + student.getBloodGroup() + "','" + student.getFatherName() + "','" + student.getMotherName() + "','" + student.getPContactNumber() + "','" + student.getCourse() + "','" + student.getBlock() + "','" + student.getStatus() + "');";
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
        public Student SearchStudent(string search)
        {
            Student student = new Student();
            string query = "select * from tblstudent where studentId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
               
                while (reader.Read())
                {
                    student.setId(reader["studentId"].ToString());
                    student.setName(reader["name"].ToString());
                    student.setAddress(reader["address"].ToString());
                    student.setGender(reader["gender"].ToString());
                    student.setDOB(reader["DOB"].ToString());
                    student.setContactNumber(reader["contactNumber"].ToString());
                    student.setBloodGroup(reader["bloodGroup"].ToString());
                    student.setFatherName(reader["fatherName"].ToString());
                    student.setMotherName(reader["motherName"].ToString());
                    student.setPContactNumber(reader["pContactNumber"].ToString());
                    student.setCourse(reader["course"].ToString());
                    student.setBlock(reader["block"].ToString());
                    student.setStatus(reader["status"].ToString());
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return student;
        }
        public Boolean UpdateStudent(Student student, string search)
        {
            Boolean isUpdated = false;
            string query = "update tblstudent set name='" + student.getName() + "', " +
                "address='" + student.getAddress() + "'," +
                "gender='" + student.getGender() + "', DOB='" + student.getDOB() + "', " +
                "contactNumber='" + student.getContactNumber() + "', bloodGroup='" + student.getBloodGroup() + "',fatherName='" + student.getFatherName() + "',motherName='" + student.getMotherName() + "',pContactNumber='" + student.getPContactNumber() + "',course='" + student.getCourse() + "',block='" + student.getBlock() + "',status='" + student.getStatus() + "' where studentId='" + search+ "';";
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
        public Boolean DeleteStudent(string id)
        {
            Boolean userDeleted = false;
            string query = "delete from tblStudent where studentId='" + id + "'";
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
