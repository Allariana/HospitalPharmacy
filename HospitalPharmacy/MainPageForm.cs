﻿using System;
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
        private int userID;
        private string username;
        private string columnname = "MedicinesOrderID";
        private string ordercolumnname = "OrderID";
        private string tablename = "MedicinesOrders";
        private string ordertablename = "Orders";
        private DataTable idNameCombo = new DataTable();
        private DataTable orderNameCombo = new DataTable();

        public MainPageForm(int userID, String username)
        {
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            tabControl.TabPages.Clear();
            tabControl.TabPages.Insert(0, stockPage);
            UserLabel.Text = username;

            ConnectionManager connection = ConnectionManager.getInstance();
            connection.getColumn(tablename, columnname, idNameCombo);
            foreach (DataRow row in idNameCombo.Rows)
            {
                medicineOrderIDComboBox.Items.Add(row["MedicinesOrderID"]);
            }
            connection.getColumn(ordertablename, ordercolumnname, orderNameCombo);
            foreach (DataRow row in orderNameCombo.Rows)
            {
                ordersComboBox.Items.Add(row["OrderID"]);
            }
        }

        private void MainPagecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.OrdersView' table. You can move, or remove it, as needed.
            this.ordersViewTableAdapter.Fill(this.pharmacyDataSet.OrdersView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.pharmacyDataSet.Departments);
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            this.generateOrderViewTableAdapter.Fill(this.pharmacyDataSet.GenerateOrderView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.MedicinesView' table. You can move, or remove it, as needed.
            this.medicinesViewTableAdapter.Fill(this.pharmacyDataSet.MedicinesView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);

        }
   
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
                 
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.userID;
            new GenerateOrderForm(id).Show();

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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.insertOrder(userID);
                MessageBox.Show("Order completed!");
                //this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
                connection.getColumn(tablename, columnname, idNameCombo);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionManager connection = ConnectionManager.getInstance();
            connection.completeOrder(ordersComboBox.SelectedItem.ToString(), userID);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*if (!changeData) return;
            switch (MessageBox.Show("Czy zapisać dane w bazie danych?", "Komunikat", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    try
                    {
                        this.Validate();
                        //this.pharmacyDataSet.Medicines.End
                        //    db.Dispose();
                        MessageBox.Show("Dane zapisane - OK", "Komunikat");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Zapisanie danych nie powiodło się : " + exc.Message);
                    }
                    break;
                case DialogResult.No:
                    break;
            }*/
        }
        
        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            new MakeOrderForm().Show();
        }

        private void medicinesOrdersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void orderGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (orderGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    if (actionComboBox.SelectedItem.ToString() == "Check Order Details")
                    {
                        new OrderDetailsForm(orderGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
                    }
                    else if (actionComboBox.SelectedItem.ToString() == "Complete Order")
                    {
                        ConnectionManager connection = ConnectionManager.getInstance();
                        connection.completeOrder(orderGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), userID);
                    }
                }
                catch (System.NullReferenceException) { MessageBox.Show("Choose what to do!"); }
            }


        }

        private void orderTabPage_Click(object sender, EventArgs e)
        {

        }

        private void medicinesOrdersPage_Click(object sender, EventArgs e)
        {
            
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void medicinesOrdersGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void medicinesViewDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                new PackageForm(medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            }
        }

        private void medicinesOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinesOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    if (chooseActionComboBox.SelectedItem.ToString() == "Check Order Details")
                    {
                        new MedicinesOrderDetailsForm(medicinesOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
                    }
                    else if (actionComboBox.SelectedItem.ToString() == "Receipt of Order")
                    {
                        ConnectionManager connection = ConnectionManager.getInstance();
                        connection.pickUpOrder(medicinesOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                }
                catch (System.NullReferenceException) { MessageBox.Show("Choose what to do!"); }
            }
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Right)
                {
                    for (int ix = 0; ix < tabControl.TabCount; ++ix)
                    {
                        if (tabControl.GetTabRect(ix).Contains(e.Location))
                        {
                            tabControl.TabPages.Remove(tabControl.SelectedTab);
                            break;
                        }
                    }
                }
        }
        
        private void openTabPage(TabPage tabPage)
        {
            if (tabControl.TabPages.Contains(tabPage)) tabControl.SelectedTab = tabPage;
            else
            {
                tabControl.TabPages.Insert(0, tabPage);
                tabControl.SelectedTab = tabPage;
            }
        }
        private void inStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(stockPage);
        }

        private void listOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(orderTabPage);
        }
        private void ListOfDepartmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void listOfPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(medicinesOrdersPage);
        }
    }
}
