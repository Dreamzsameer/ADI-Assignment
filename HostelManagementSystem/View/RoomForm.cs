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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = "";
            txtNumberOfBeds.Text = "";
            txtDescription.Text = "";
            txtStatus.Text = "";
            txtBlock.Text = "";
            txtFee.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text;
            string numberOfBeds= txtNumberOfBeds.Text;
            string description= txtDescription.Text;
            string status= txtStatus.Text;
            string block= txtBlock.Text;
            string fee = txtFee.Text;

            Room room = new Room();
            room.setRoomNumber(roomNumber);
            room.setNumberOfBeds(numberOfBeds);
            room.setDescription(description);
            room.setStatus(status);
            room.setBlock(block);
            room.setFee(fee);

            RoomController roomController = new RoomController();
           bool i =  roomController.AddRoom(room);
            if (i == true) {
                MessageBox.Show("Room added Successfully");

                txtRoomNumber.Text="";
                 txtNumberOfBeds.Text="";
                 txtDescription.Text="";
                txtStatus.Text="";
                txtBlock.Text="";
                txtFee.Text="";
            }
            else {
                MessageBox.Show("Room is not added");
            }



        }
    }
}
