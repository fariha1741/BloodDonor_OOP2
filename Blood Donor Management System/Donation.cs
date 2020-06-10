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
    public partial class Donation : Form
    {
        BEL allInfo = new BEL();
        DAL daObject = new DAL();
        public Donation(BEL allInfo)
        {
            InitializeComponent();
            this.allInfo = allInfo;

            helloUserLabel.Text = "WELCOME "+this.allInfo.userName.ToUpper()+" !";

            activityLabel.Text = allInfo.activity.ToUpper();

            if (allInfo.activity == "inactive")
            {
                activityLabel.ForeColor = Color.Red;
                activityChangingLabel.Text = "Change to ACTIVE";
            }
            else if (allInfo.activity == "active")
            {
                activityLabel.ForeColor = Color.Green;
                activityChangingLabel.Text = "Change to INACTIVE";
            }

            if (allInfo.requested == "yes")
            {
                requestLabel.ForeColor = Color.Green;
            }
            else if (allInfo.requested == "no")
            {
                requestLabel.ForeColor = Color.Red;
            }

        }

        private void logoutLabel_Click(object sender, EventArgs e)
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

        private void activityChangingLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int result;

            if (activityLabel.Text == "INACTIVE")
            {
                
                result = daObject.setActivity(allInfo.userName,"active");
                if(result > 0)
                {
                    activityLabel.Text = "ACTIVE";
                    activityLabel.ForeColor = Color.Green;
                    activityChangingLabel.Text = "Change to INACTIVE";
                }
                else
                {
                    MessageBox.Show("Error occured while changing activity");
                }
                
            }
            else if(activityLabel.Text == "ACTIVE")
            {
                result = daObject.setActivity(allInfo.userName, "inactive");
                if (result > 0)
                {
                    activityLabel.Text = "INACTIVE";
                    activityLabel.ForeColor = Color.Red;
                    activityChangingLabel.Text = "Change to ACTIVE";
                }
                else
                {
                    MessageBox.Show("Error occured while changing activity");
                }
                
            }

        }

        private void requestLabel_Click(object sender, EventArgs e)
        {
            if(requestLabel.ForeColor == Color.Red)
            {
                int result = daObject.setRequest(allInfo.userName, "yes");
                if (result > 0)
                {
                    requestLabel.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Failed to change request state !");
                }
                
            }
            else if(requestLabel.ForeColor == Color.Green)
            {
                int result = daObject.setRequest(allInfo.userName, "no");

                if(result > 0 )
                {
                    requestLabel.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Failed to change request state !");
                }

            }

            
        }

        private void donorsLabel_Click(object sender, EventArgs e)
        {
            Form dns = new Donors();
            dns.Show();
            this.Hide();
        }

        private void requestedLabel_Click(object sender, EventArgs e)
        {
            Form rqst = new Requests();
            rqst.Show();
            this.Hide();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            Form prf = new Profile(allInfo);
            prf.Show();
            this.Hide();
        }
    }
}
