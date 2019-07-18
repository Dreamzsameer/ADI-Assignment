using HostelManagementSystem.Controller;
using HostelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            CourseController courseController = new CourseController();
            Course course = courseController.SearchCourse(search);

            txtCourseId.Text = course.getCourseId();
            txtCourseName.Text = course.getCourseName();
            txtNumberOfYear.Text = course.getNumberOfYear();
            txtStatus.Text = course.getStatus();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCourseId.Text = "";
            txtCourseName.Text ="";
            txtNumberOfYear.Text = "";
            txtStatus.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtCourseId.Text;
            string courseName = txtCourseName.Text;
            string numberOfYear = txtNumberOfYear.Text;
            string status = txtStatus.Text;

            

            Course course = new Course();
            course.setCourseId(id);
            course.setCourseName(courseName);
            course.setNumberOfYear(numberOfYear);
            course.setStatus(status);

            CourseController courseController = new CourseController();
           bool i =  courseController.UpdateCourse(course);
            if (i == true)
            {
                MessageBox.Show("Course infomation edited successfully!");
            }
            else {
                MessageBox.Show("Course informaton is not edited!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtCourseId.Text;
            CourseController courseController = new CourseController();
            bool i = courseController.DeleteCourse(id);
            if (i == true)
            {
                MessageBox.Show("Course Deleted Successffully!");
               txtCourseId.Text="";
               txtCourseName.Text="";
               txtNumberOfYear.Text="";
               txtStatus.Text="";
            }
            else
            {
                MessageBox.Show("Course is not Deleted!");
            }
        }
    }
}
