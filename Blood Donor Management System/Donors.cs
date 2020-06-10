using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALayer;

namespace Blood_Donor_Management_System
{
    public partial class Donors : Form
    {
        DAL daObj = new DAL();
        public Donors()
        {
            InitializeComponent();

            donorsDataGrid.AutoGenerateColumns = false;

            donorsDataGrid.DataSource = daObj.getAllDonors();          
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
