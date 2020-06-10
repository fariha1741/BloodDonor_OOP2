namespace Blood_Donor_Management_System
{
    partial class Donors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.donorsUserLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.donorsDataGrid = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blood_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 5);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.donorsUserLabel);
            this.panel6.Controls.Add(this.backLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1080, 100);
            this.panel6.TabIndex = 29;
            // 
            // donorsUserLabel
            // 
            this.donorsUserLabel.AutoSize = true;
            this.donorsUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorsUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.donorsUserLabel.Location = new System.Drawing.Point(12, 29);
            this.donorsUserLabel.Name = "donorsUserLabel";
            this.donorsUserLabel.Size = new System.Drawing.Size(196, 46);
            this.donorsUserLabel.TabIndex = 2;
            this.donorsUserLabel.Text = "DONORS";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.backLabel.Location = new System.Drawing.Point(939, 29);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(129, 46);
            this.backLabel.TabIndex = 0;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // donorsDataGrid
            // 
            this.donorsDataGrid.AllowUserToAddRows = false;
            this.donorsDataGrid.AllowUserToDeleteRows = false;
            this.donorsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.donorsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_name,
            this.phone,
            this.blood_group,
            this.address});
            this.donorsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorsDataGrid.Location = new System.Drawing.Point(0, 105);
            this.donorsDataGrid.Name = "donorsDataGrid";
            this.donorsDataGrid.ReadOnly = true;
            this.donorsDataGrid.RowTemplate.Height = 28;
            this.donorsDataGrid.Size = new System.Drawing.Size(1080, 615);
            this.donorsDataGrid.TabIndex = 31;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Username";
            this.user_name.Name = "user_name";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // blood_group
            // 
            this.blood_group.DataPropertyName = "blood_group";
            this.blood_group.HeaderText = "Blood Group";
            this.blood_group.Name = "blood_group";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // Donors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.donorsDataGrid);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donors";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label donorsUserLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.DataGridView donorsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn blood_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}