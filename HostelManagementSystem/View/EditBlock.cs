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
    public partial class EditBlock : Form
    {
        public EditBlock()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtBlockId.Text;
            BlockController blockController = new BlockController();
           bool i =  blockController.DeleteBlock(id);
            if (i == true)
            {
                MessageBox.Show("Selected Block Information deleted successfully!");

                txtBlockId.Text = "";
                txtBlockName.Text = "";
                txtGender.Text = "";
                txtDescription.Text = "";
                txtStatus.Text = "";
            }
            else {
                MessageBox.Show("Selected Block Information is not deleted successfully!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            BlockController blockController = new BlockController();
            BlockBuilding block = blockController.SearchBlock(search);

            txtBlockId.Text = block.getBlockId();
            txtBlockName.Text = block.getBlockName();
            txtGender.Text = block.getGender();
            txtDescription.Text = block.getDescription();
            txtStatus.Text = block.getStatus();
            
                }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string blockId= txtBlockId.Text;
            string blockName= txtBlockName.Text;
            string gender= txtGender.Text;
            string description= txtDescription.Text;
            string status= txtStatus.Text;

            BlockBuilding block = new BlockBuilding();
            block.setBlockId(blockId);
            block.setBlockName(blockName);
            block.setGender(gender);
            block.setDescription(description);
            block.setStatus(status);

            BlockController blockController = new BlockController();
          bool i =   blockController.UpdateBlock(block);

            if (i == true)
            {
                MessageBox.Show("Block Information updated successfully!");
            }
            else {
                MessageBox.Show("Block Information is not updated successfully!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBlockId.Text = "";
            txtBlockName.Text ="";
            txtGender.Text = "";
            txtDescription.Text = "";
            txtStatus.Text ="";
        }
    }
}
