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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string gender = txtGender.Text;
            string DOB = txtDOB.Text;
            string contactNumber = txtContactNumber.Text;
            string bloodGroup = txtBloodGroup.Text;
            string fatherName = txtFatherName.Text;
            string motherName = txtMotherName.Text;
            string parentContactNumber = txtPContactNumber.Text;
            string course = txtCourse.Text;
            string block = txtBlock.Text;
            string status = txtStatus.Text;

            Student student = new Student();
            student.setName(name);
            student.setAddress(address);
            student.setGender(gender);
            student.setDOB(DOB);
            student.setContactNumber(contactNumber);
            student.setBloodGroup(bloodGroup);
            student.setFatherName(fatherName);
            student.setMotherName(motherName);
            student.setPContactNumber(parentContactNumber);
            student.setCourse(course);
            student.setBlock(block);
            student.setStatus(status);

            StudentController studentController = new StudentController();
           bool result =  studentController.AddStudent(student);
            if (result == true) {
                MessageBox.Show("Student added successfully");

                txtName.Text="";
                txtAddress.Text="";
                txtGender.Text="";
                txtDOB.Text="";
                txtContactNumber.Text="";
                txtBloodGroup.Text="";
                txtFatherName.Text="";
                txtMotherName.Text="";
                txtPContactNumber.Text="";
                txtCourse.Text="";
                txtBlock.Text="";
                txtStatus.Text="";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtGender.Text = "";
            txtDOB.Text = "";
            txtContactNumber.Text = "";
            txtBloodGroup.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            txtPContactNumber.Text = "";
            txtCourse.Text = "";
            txtBlock.Text = "";
            txtStatus.Text = "";
        }
    }
}
