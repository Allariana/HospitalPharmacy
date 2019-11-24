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
        private string username;
        int userID;
        string columnname = "MedicinesOrderID";
        string ordercolumnname = "OrderID";
        string tablename = "MedicinesOrders";
        string ordertablename = "Orders";
        bool changeData = false;
        DataTable idNameCombo = new DataTable();
        DataTable orderNameCombo = new DataTable();

        public MainPageForm(int userID, String username)
        {
            this.username = username;
            this.userID = userID;
            InitializeComponent();
            this.UserLabel.Text = username;

            ConnectionManager connection = ConnectionManager.getInstance();
            //this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
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

        private void UserLabel_Click(object sender, EventArgs e) { }

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
            int id;
            id = this.userID;
            new GenerateOrderForm(id).Show();

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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // new MainPageForm(this.UserLabel.Text).Show();
        }

        private void generateOrderViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if (!changeData) return;
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
            }
        }

        private void medicinesGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changeData = true;
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            new MakeOrderForm().Show();
        }

        private void medicinesOrdersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinesOrdersGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    if (chooseActionComboBox.SelectedItem.ToString() == "Check Order Details")
                    {
                        new MedicinesOrderDetailsForm(medicinesOrdersGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
                    }
                    else if (actionComboBox.SelectedItem.ToString() == "Receipt of Order")
                    {
                        ConnectionManager connection = ConnectionManager.getInstance();
                        connection.pickUpOrder(medicinesOrdersGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                }
                catch (System.NullReferenceException) { MessageBox.Show("Choose what to do!"); }
            }
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
            medicinesOrdersGridView.Update();
            medicinesOrdersGridView.Refresh();
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
    }
}
