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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseName = txtCourse.Text;
            string numberOfYear = txtNumberOfYear.Text;
            string status = txtStatus.Text;

            Course course = new Course();
            course.setCourseName(courseName);
            course.setNumberOfYear(numberOfYear);
            course.setStatus(status);

            CourseController courseController = new CourseController();
           bool i =  courseController.AddCourse(course);
            if (i == true)
            {
                MessageBox.Show("Course Added Successfully");

                txtCourse.Text="";
               txtNumberOfYear.Text="";
                 txtStatus.Text="";
            }
            else {
                MessageBox.Show("Course is not added");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCourse.Text = "";
            txtNumberOfYear.Text = "";
            txtStatus.Text = "";
        }
    }
}
