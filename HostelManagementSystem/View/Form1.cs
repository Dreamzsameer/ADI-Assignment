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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;

            User user = new User();
            user.setUsername(username);
            user.setPassword(password);

            UserController userController = new UserController();
            bool authenticate = userController.Authenticate(user);
            if (authenticate == true)
            {

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
