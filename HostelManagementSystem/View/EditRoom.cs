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
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            RoomController roomController = new RoomController();
            Room room = roomController.SearchRoom(search);
            txtRoomId.Text = room.getRoomId();
            txtRoomNumber.Text = room.getRoomNumber();
            txtNumberOfBeds.Text = room.getNumberOfBeds();
            txtDescription.Text = room.getDescription();
            txtStatus.Text = room.getStatus();
            txtBlock.Text = room.getBlock();
            txtFee.Text = room.getFee();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRoomId.Text ="";
            txtRoomNumber.Text ="";
            txtNumberOfBeds.Text = "";
            txtDescription.Text = "";
            txtStatus.Text ="";
            txtBlock.Text = "";
            txtFee.Text = "";

            txtSearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomId = txtRoomId.Text;
            string roomNumber = txtRoomNumber.Text;
            string numberOfBeds = txtNumberOfBeds.Text;
            string description = txtDescription.Text;
            string status = txtStatus.Text;
            string block = txtBlock.Text;
            string fee = txtFee.Text;

            string search = txtSearch.Text;

            Room room = new Room();
            room.setRoomId(roomId);
            room.setRoomNumber(roomNumber);
            room.setNumberOfBeds(numberOfBeds);
            room.setDescription(description);
            room.setStatus(status);
            room.setBlock(block);
            room.setFee(fee);

            RoomController roomController = new RoomController();
            bool i = roomController.UpdateRoom(room, search);
            if (i == true)
            {
                MessageBox.Show("Room Informtion Updated Successfully!");
            }
            else {
                MessageBox.Show("Room Information is not updated!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtRoomId.Text;
            RoomController roomController = new RoomController();
            bool i  = roomController.DeleteRoom(id);

            if (i == true)
            {
                MessageBox.Show("Selected Room Deleted Successfully");
                txtRoomId.Text = "";
                txtRoomNumber.Text = "";
                txtNumberOfBeds.Text = "";
                txtDescription.Text = "";
                txtStatus.Text = "";
                txtBlock.Text = "";
                txtFee.Text = "";

                txtSearch.Text = "";
            }
            else {
                MessageBox.Show("Selected Room is not Deleted!");
            }
        }
    }
}
