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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
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
            string motherName = txtMother.Text;
            string pContactNumber = txtPContactNumber.Text;
            string designation = txtDesignation.Text;
            string block = txtBlock.Text;
            string status = txtStatus.Text;

            string search = txtSearch.Text;

            Staff staff = new Staff();
            staff.setName(name);
            staff.setAddress(address);
            staff.setGender(gender);
            staff.setDOB(DOB);
            staff.setContactNumber(contactNumber);
            staff.setBloodGroup(bloodGroup);
            staff.setFatherName(fatherName);
            staff.setMotherName(motherName);
            staff.setPContactNumber(pContactNumber);
            staff.setDesignation(designation);
            staff.setBlock(block);
            staff.setStatus(status);

            StaffController staffController = new StaffController();
            bool i = staffController.UpdateStaff(staff, search);
            if (i == true)
            {
                MessageBox.Show("Staff Information Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Staff Informatio is not Updted!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            StaffController staffController = new StaffController();
            Staff staff =  staffController.SearchStaff(search);

            txtStaffId.Text = staff.getId();
            txtName.Text = staff.getName();
            txtAddress.Text = staff.getAddress();
            txtGender.Text = staff.getGender();
            txtDOB.Text = staff.getDOB();
            txtContactNumber.Text = staff.getContactNumber();
            txtBloodGroup.Text = staff.getBloodGroup();
            txtFatherName.Text = staff.getFatherName();
            txtMother.Text = staff.getMotherName();
            txtPContactNumber.Text = staff.getPContactNumber();
            txtDesignation.Text = staff.getDesignation();
            txtBlock.Text = staff.getBlock();
            txtStatus.Text = staff.getStatus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtStaffId.Text = "";
            txtName.Text ="";
             txtAddress.Text="";
             txtGender.Text="";
             txtDOB.Text="";
             txtContactNumber.Text="";
             txtBloodGroup.Text="";
             txtFatherName.Text="";
             txtMother.Text="";
             txtPContactNumber.Text="";
             txtDesignation.Text="";
             txtBlock.Text="";
             txtStatus.Text="";

             txtSearch.Text="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            StaffController staffController = new StaffController();
             bool i = staffController.DeleteStaff(staffId);
            if (i == true)
            {
                MessageBox.Show("Selected Staff Deleted Successfully!");
                txtStaffId.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtGender.Text = "";
                txtDOB.Text = "";
                txtContactNumber.Text = "";
                txtBloodGroup.Text = "";
                txtFatherName.Text = "";
                txtMother.Text = "";
                txtPContactNumber.Text = "";
                txtDesignation.Text = "";
                txtBlock.Text = "";
                txtStatus.Text = "";

                txtSearch.Text = "";

            }
            else {
                MessageBox.Show("Selected Staff is not Deleted.");
            }
        }
    }
}
