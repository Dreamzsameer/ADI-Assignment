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
    class CourseController
    {

        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        public CourseController() {

            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = Connection.GetConnection();
            }


        }

        public Boolean AddCourse(Course course)
        {
            Boolean userAdded = false;
            string query = "insert into tblcourse (courseName, numberOfYear, Status)" +
                "values ('" + course.getCourseName() + "', '" + course.getNumberOfYear() + "', '" + course.getStatus() + "')";
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
        public Course SearchCourse(string search)
        {
            Course course = new Course();
            string query = "select * from tblcourse where courseId='" + search + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    course.setCourseId(reader["courseId"].ToString());
                    course.setCourseName(reader["courseName"].ToString());
                    course.setNumberOfYear(reader["numberOfYear"].ToString());
                    course.setStatus(reader["Status"].ToString());
                   
                   

                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return course;
        }
        public Boolean UpdateCourse(Course course)
        {
            Boolean isUpdated = false;
            string query = "update tblCourse set courseName='" + course.getCourseName() + "', " +
                "numberOfYear='" + course.getNumberOfYear() + "'," +
                "Status='" + course.getStatus() + "'where courseId='" + course.getCourseId() + "';";
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
        public Boolean DeleteCourse(string id)
        {
            Boolean courseDeleted = false;
            string query = "delete from tblCourse where courseId='" + id + "'";
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
