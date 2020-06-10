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
    public partial class Login : Form
    {
        BEL beObj = new BEL();
        DAL daObj = new DAL();

        public Login()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            beObj.userName = userNameTextBox.Text;
            beObj.password = passwordTextBox.Text;

            bool result = daObj.login(beObj);

            if(result == true)
            {

                BEL allInfo = new BEL();
                allInfo =  daObj.getAll(beObj);

                if(allInfo != null)
                {
                    Form df = new Donation(allInfo);
                    df.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unable to fetch user data !");
                }              
            }
            else
            {
                MessageBox.Show("No Match Found !");
                userNameTextBox.Clear();
                passwordTextBox.Clear();
            }

        }

        private void signupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sf = new Signup();
            sf.Show();
            this.Hide();
        }
    }
}
