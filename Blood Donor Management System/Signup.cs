using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BELayer;
using DALayer;

namespace Blood_Donor_Management_System
{
    public partial class Signup : Form
    {
        public BEL beObj = new BEL();
        public DAL daObj = new DAL();

        public Signup()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            getLoginWindow();
        }

        private void signupCancelButton_Click(object sender, EventArgs e)
        {
            getLoginWindow();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "" && passwordTextBox.Text != "" && phoneTextBox.Text != "" && bgTextBox.Text != "" && addressTextBox.Text != "")
            {

                beObj.userName = userNameTextBox.Text;
                beObj.password = passwordTextBox.Text;
                beObj.phone = phoneTextBox.Text;
                beObj.bloodGroup = bgTextBox.Text;
                beObj.address = addressTextBox.Text;
                beObj.activity = "inactive";
                beObj.requested = "no";

                int result = daObj.userDetailsInsertMethod(beObj);

                if (result > 0)
                {
                    MessageBox.Show("Sign up complete ! You will be redirected to login screen !");
                    getLoginWindow();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Error occured ! Try again !");
                }
                else if (result < 0)
                {
                    MessageBox.Show("Username not available");
                }
            }
            else
            {
                MessageBox.Show("Error ! There are empty fields !");
            }
                            
        }

        void getLoginWindow()
        {

            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Login")
                {
                    frm.Show();
                }
            }

            this.Close();
        }
    }
}
