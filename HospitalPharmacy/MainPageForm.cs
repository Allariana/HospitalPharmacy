using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalPharmacy
{
    public partial class MainPageForm : Form
    {
        PharmacyEntities pharmacyContext;
        public MainPageForm(string username)
        {
            InitializeComponent();
            this.UserLabel.Text = username;
            try
            {
                pharmacyContext = new PharmacyEntities();
                departmentsGridView.DataSource = pharmacyContext.DepartmentsViews.ToList();
                medicinesGridView.DataSource = pharmacyContext.MedicinesViews.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
                private void MainPagecs_Load(object sender, EventArgs e)
        {

        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void listOfDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listOfDepartmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           tabPage2.Show();
        }

        private void departmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
