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
                medicinesOrdersGridView.DataSource = pharmacyContext.MedicinesOrdersViews.ToList();
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionManager connection = new ConnectionManager();
            DataTable idNameCombo = new DataTable();
            string columnname = "MedicinesOrderID";
            string tablename = "MedicinesOrders";
            connection.getTable(tablename, columnname, idNameCombo);
            foreach (DataRow row in idNameCombo.Rows)
            {
                medicineOrderIDComboBox.Items.Add(row["MedicinesOrderID"]);
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
            tabControl.SelectedTab = departmentsPage;
             
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

        private void orderButton_Click(object sender, EventArgs e)
        {
            new MakingOrderForm().Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string username = this.UserLabel.Text;
            new GenerateOrderForm(username).Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //medicinesOrderDetailsGridView.DataSource = pharmacyContext.MedicineOrderDetails;
        }

        private void stockPage_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            new MedicinesOrderDetailsForm(medicineOrderIDComboBox.SelectedItem.ToString()).Show();
        }
    }
}
