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
    public partial class Requests : Form
    {

        DAL daObj = new DAL();

        public Requests()
        {
            InitializeComponent();

            requestsDataGrid.AutoGenerateColumns = false;

            requestsDataGrid.DataSource = daObj.getAllRequests();
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
