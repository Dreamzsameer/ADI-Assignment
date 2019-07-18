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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name= txtName.Text;
            string address=txtAddress.Text;
            string DOB=txtDOB.Text;
            string gender=txtGender.Text;
            string contactNumber=txtContactNumber.Text;
            string bloodGroup=txtBloodGroup.Text;
            string fatherName = txtFatherName.Text;
            string motherName=txtMotherName.Text;
            string pContactNumber=txtPContactNumber.Text;
            string designtion=txtDesignation.Text;
            string block=txtBlock.Text;
            string status=txtStatus.Text;

            Staff staff = new Staff();
            staff.setName(name);
            staff.setAddress(address);
            staff.setDOB(DOB);
            staff.setGender(gender);
            staff.setContactNumber(contactNumber);
            staff.setBloodGroup(bloodGroup);
            staff.setFatherName(fatherName);
            staff.setMotherName(motherName);
            staff.setPContactNumber(pContactNumber);
            staff.setDesignation(designtion);
            staff.setBlock(block);
            staff.setStatus(status);

            StaffController staffController = new StaffController();
           bool i = staffController.AddStaff(staff);
            if (i == true)
            {
                MessageBox.Show("Staff Added Successfully");
                 txtName.Text="";
                txtAddress.Text="";
                 txtDOB.Text="";
                txtGender.Text="";
                 txtContactNumber.Text="";
               txtBloodGroup.Text="";
                 txtFatherName.Text="";
                 txtMotherName.Text="";
                 txtPContactNumber.Text="";
                 txtDesignation.Text="";
                txtBlock.Text="";
                txtStatus.Text="";
            }
            else {
                MessageBox.Show("Staff Not Added");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "";
            txtGender.Text = "";
            txtContactNumber.Text = "";
            txtBloodGroup.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            txtPContactNumber.Text = "";
            txtDesignation.Text = "";
            txtBlock.Text = "";
            txtStatus.Text = "";
        }
    }
}
