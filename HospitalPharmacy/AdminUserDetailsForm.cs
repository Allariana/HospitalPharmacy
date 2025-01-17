﻿using System;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AdminUserDetailsForm : Form
    {
        ConnectionManager connection = ConnectionManager.getInstance();
        public AdminUserDetailsForm()
        {
            InitializeComponent();
        }

        private void userDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            userDetailsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void AdminUserDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmacyDataSet.Users);
            userDetailsTableAdapter.Fill(pharmacyDataSet.UserDetails);
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            using (PathToPhoto pathToPhoto = new PathToPhoto())
            {
                if (pathToPhoto.ShowDialog() == DialogResult.OK)
                {
                    connection.insertPhoto(pathToPhoto.value, userIDLabel2.Text);
                    AdminUserDetailsForm_Load(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PathToPhoto pathToPhoto = new PathToPhoto())
            {
                if (pathToPhoto.ShowDialog() == DialogResult.OK)
                {
                    connection.insertPhoto(pathToPhoto.value, bindingNavigatorPositionItem.ToString());
                    AdminUserDetailsForm_Load(null, null);
                }
            }
        }
    }
}
