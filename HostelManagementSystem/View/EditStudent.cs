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
    public partial class EditStudent : Form
    {
        public EditStudent()
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
            StudentController studentController = new StudentController();
           Student student = studentController.SearchStudent(search);

            txtStudentId.Text = student.getId();
            txtName.Text = student.getName();
            txtAddress.Text = student.getAddress();
            txtGender.Text = student.getGender();
            txtDOB.Text = student.getDOB();
            txtContactNumber.Text = student.getContactNumber();
            txtBloodGroup.Text = student.getBloodGroup();
            txtFatherName.Text = student.getFatherName();
            txtMotherName.Text = student.getMotherName();
            txtPContactNumber.Text = student.getPContactNumber();
            txtCourse.Text = student.getCourse();
            txtBlock.Text = student.getBlock();
            txtStatus.Text = student.getStatus();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
           string name =  txtName.Text;
           string address =  txtAddress.Text ;
           string gender =  txtGender.Text ;
            string DOB = txtDOB.Text;
           string contactNumber =  txtContactNumber.Text ;
            string bloodGroup = txtBloodGroup.Text ;
           string fatherName = txtFatherName.Text ;
            string motherName = txtMotherName.Text;
            string pContactNumber = txtPContactNumber.Text ;
           string course =  txtCourse.Text ;
           string block =  txtBlock.Text ;
            string status = txtStatus.Text ;

            string search = txtSearch.Text;

            Student student = new Student();
            student.setName(name);
            student.setAddress(address);
            student.setGender(gender);
            student.setDOB(DOB);
            student.setContactNumber(contactNumber);
            student.setBloodGroup(bloodGroup);
            student.setFatherName(fatherName);
            student.setMotherName(motherName);
            student.setPContactNumber(pContactNumber);
            student.setCourse(course);
            student.setBlock(block);
            student.setStatus(status);

            StudentController studentController = new StudentController();
            bool i = studentController.UpdateStudent(student,search);
            if (i == true)
            {
                MessageBox.Show("Student Information Updated Successfully!");
            }
            else {
                MessageBox.Show("Student Informatio is not Updted!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtStudentId.Text;

            StudentController studentController = new StudentController();
           bool i =  studentController.DeleteStudent(id);
            if (i == true)
            {
                MessageBox.Show("Student Information deleted succesfully!");
                txtStudentId.Text = "";
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
            else {
                MessageBox.Show("Student Information not deleted ");

            }
        }
    }
}
