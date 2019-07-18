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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword) {
                MessageBox.Show("Password and Confirm password is not same");
            }
            else { 
            User user = new User();
            user.setFirstName(firstname);
            user.setLastName(lastname);
            user.setUsername(username);
            user.setPassword(password);



            UserController userController = new UserController();
            if (userController.AddUser(user) == true)
            {
                MessageBox.Show("Thank you for registering with system");

                   txtFirstName.Text="";
                    txtLastName.Text="";
                    txtusername.Text="";
                      txtpassword.Text="";
                    txtConfirmPassword.Text="";

                }
            else {
                MessageBox.Show("Registration failed");
            }
            }
        }
    }
}
