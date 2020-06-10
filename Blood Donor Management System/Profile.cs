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

namespace Blood_Donor_Management_System
{
    public partial class Profile : Form
    {
        public Profile(BEL obj)
        {
            InitializeComponent();

            if(obj != null)
            {
                userNameLabel.Text = obj.userName;
                phoneLabel.Text = obj.phone;
                bloodGroupLabel.Text = obj.bloodGroup;
                addressLabel.Text = obj.address;
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Donation")
                {
                    frm.Show();
                }
            }

            this.Close();
        }
    }
}
