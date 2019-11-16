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
        private string username;
        string columnname = "MedicinesOrderID";
        string ordercolumnname = "OrderID";
        string tablename = "MedicinesOrders";
        string ordertablename = "Orders";
        DataTable idNameCombo = new DataTable();
        DataTable orderNameCombo = new DataTable();
        public MainPageForm(string username)
        {
            this.username = username;
            InitializeComponent();
            this.UserLabel.Text = username;
            
            try
            {
                pharmacyContext = new PharmacyEntities();
                departmentsGridView.DataSource = pharmacyContext.DepartmentsViews.ToList();
                medicinesGridView.DataSource = pharmacyContext.MedicinesViews.ToList();
                medicinesOrdersGridView.DataSource = pharmacyContext.MedicinesOrdersViews.ToList();
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
                orderGridView.DataSource = pharmacyContext.OrdersViews.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionManager connection = ConnectionManager.getInstance();
            this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
                        
            connection.getTable(tablename, columnname, idNameCombo);
            foreach (DataRow row in idNameCombo.Rows)
            {
                medicineOrderIDComboBox.Items.Add(row["MedicinesOrderID"]);
            }
            connection.getTable(ordertablename, ordercolumnname, orderNameCombo);
            foreach (DataRow row in orderNameCombo.Rows)
            {
                ordersComboBox.Items.Add(row["OrderID"]);
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

        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = generateOrderTabPage;
            /*try {
                new GenerateOrderForm(username).Show();
            }
            finally {
                medicinesOrdersGridView.DataSource = pharmacyContext.MedicinesOrdersViews.ToList();
            }*/
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeOrderStatusButton_Click(object sender, EventArgs e)
        {
            ConnectionManager connection = ConnectionManager.getInstance();
            connection.pickUpOrder(medicineOrderIDComboBox.SelectedItem.ToString());
            medicinesOrdersGridView.DataSource = pharmacyContext.MedicinesOrdersViews.ToList();
            medicinesGridView.DataSource = pharmacyContext.MedicinesViews.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MainPageForm(this.UserLabel.Text).Show();
        }

        private void generateOrderViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.insertOrder(username);
                MessageBox.Show("Order completed!");
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
                this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
                medicinesOrdersGridView.DataSource = pharmacyContext.MedicinesOrdersViews.ToList();
                connection.getTable(tablename, columnname, idNameCombo);
                foreach (DataRow row in idNameCombo.Rows)
                {
                    medicineOrderIDComboBox.Items.Add(row["MedicinesOrderID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medicineOrderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new OrderDetailsForm(ordersComboBox.SelectedItem.ToString()).Show();
        }
    }
}
