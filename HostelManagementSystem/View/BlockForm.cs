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
    public partial class BlockForm : Form
    {
        public BlockForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string block = txtBlockName.Text;
            string gender= txtGender.Text;
            string description= txtDescription.Text;
            string status= txtStatus.Text;

            BlockBuilding blockBuilding = new BlockBuilding();
            blockBuilding.setBlockName(block);
            blockBuilding.setGender(gender);
            blockBuilding.setDescription(description);
            blockBuilding.setStatus(status);

            BlockController blockController = new BlockController();
           bool i = blockController.AddBlock(blockBuilding);
            if (i == true)
            {
                MessageBox.Show("Block has been added Successfully");
                txtBlockName.Text="";
                 txtGender.Text="";
                 txtDescription.Text="";
               txtStatus.Text="";
            }
            else {
                MessageBox.Show("Block has not been added");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBlockName.Text = "";
            txtGender.Text = "";
            txtDescription.Text = "";
            txtStatus.Text = "";
        }
    }
}
