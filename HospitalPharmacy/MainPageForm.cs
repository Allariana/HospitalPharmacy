using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class MainPageForm : Form
    {
        private int userID;
        private string username;
        public MainPageForm(int userID, String username)
        {
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            tabControl.TabPages.Clear();
            tabControl.TabPages.Insert(0, currentOrderTabPage);
            UserLabel.Text = username;                                
        }

        private void MainPagecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.ProfileView' table. You can move, or remove it, as needed.
            this.profileViewTableAdapter.Fill(this.pharmacyDataSet.ProfileView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.PharmacistsView' table. You can move, or remove it, as needed.
            this.pharmacistsViewTableAdapter.Fill(this.pharmacyDataSet.PharmacistsView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.Suppliers);
            panel.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel3.BackColor = Color.FromArgb(100, 255, 255, 255);

            // TODO: This line of code loads data into the 'pharmacyDataSet.Departments' table. You can move, or remove it, as needed.
            departmentsTableAdapter.Fill(pharmacyDataSet.Departments);
            receiptMedicinesOrdersViewTableAdapter.Fill(pharmacyDataSet.ReceiptMedicinesOrdersView);
            currentOrdersViewTableAdapter.Fill(pharmacyDataSet.CurrentOrdersView);
            ordersViewTableAdapter.Fill(pharmacyDataSet.OrdersView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            generateOrderViewTableAdapter.Fill(pharmacyDataSet.GenerateOrderView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.MedicinesView' table. You can move, or remove it, as needed.
            this.medicinesViewTableAdapter.Fill(this.pharmacyDataSet.MedicinesView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);
            this.medicinesOrdersViewTableAdapter.Fill(this.pharmacyDataSet.MedicinesOrdersView);
            

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
            
        }

        private void stockPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void medicineOrderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                       
        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            
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
        private void medicinesOrdersViewDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinesOrdersViewDataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                new MedicinesOrderDetailsForm(medicinesOrdersViewDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
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
            openTabPage(currentOrderTabPage);
        }
        private void ListOfDepartmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void listOfPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(purchaseDetailsPage);
        }

        private void purchaseOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(purchaseDetailsPage);
        }
       
        private void receiptOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(recepitOrderTabPage);
        }

        private void medicinesViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    new PackageForm(medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void departmentsAndOrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void currentOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                new OrderDetailsForm(currentOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            }
        }

        private void receiptMedicinesOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionManager connection = ConnectionManager.getInstance();
            switch (MessageBox.Show("Are you sure you want to mark this order as done?", "Confirmation", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:


                    connection.pickUpOrder(receiptMedicinesOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //receiptMedicinesOrdersViewDataGridView.DataSource = receiptMedicinesOrdersViewTableAdapter;
                    receiptMedicinesOrdersViewDataGridView.Update();
                    receiptMedicinesOrdersViewDataGridView.Refresh();
                    /*medicinesViewDataGridView.DataSource = medicinesViewTableAdapter;
                    medicinesViewDataGridView.Refresh();*/
                    /*
                    medicinesOrdersViewDataGridView.DataSource = medicinesOrdersViewTableAdapter;
                    medicinesOrdersViewDataGridView.Refresh();
                    medicinesOrdersViewDataGridView1.DataSource = medicinesOrdersViewTableAdapter;
                    medicinesOrdersViewDataGridView1.Refresh();
                    medicinesOrdersViewDataGridView2.DataSource = medicinesOrdersViewTableAdapter;
                    medicinesOrdersViewDataGridView2.Refresh();
                    medicinesViewDataGridView.DataSource = medicinesViewTableAdapter;
                    medicinesViewDataGridView.Refresh();*/
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void currentOrderTabPage_Click(object sender, EventArgs e)
        {

        }

        private void completeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(orderTabPage);
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(historyOrdersTabPage);
        }

        private void ordersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ordersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                new OrderDetailsForm(ordersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            }
        }

        private void completeOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int id;
                id = this.userID;
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.completeOrder(completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),id);
                currentOrdersViewDataGridView.DataSource = currentOrdersViewTableAdapter;
                currentOrdersViewDataGridView.Refresh();
                completeOrdersViewDataGridView.DataSource = currentOrdersViewTableAdapter;
                completeOrdersViewDataGridView.Refresh();
            }
        }

        private void archivesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void listOfSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(suppliersTabPage);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new ProfileForm(userID).Show();
        }

        private void listOfPharmacistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(pharmacistTabPage);
        }

        private void userIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptMedicinesOrdersViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void makeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MakeOrderForm(userID).Show();
        }

        private void generateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id;
            id = this.userID;
            using (GenerateOrderForm generateOrderForm = new GenerateOrderForm(id))
            {
                if (generateOrderForm.ShowDialog() == DialogResult.OK)
                {
                    //medicinesOrdersViewDataGridView1.DataSource = medicinesOrdersViewTableAdapter;
                    medicinesOrdersViewDataGridView1.Update();
                    medicinesOrdersViewDataGridView1.Refresh();
                    //receiptMedicinesOrdersViewDataGridView.DataSource = receiptMedicinesOrdersViewTableAdapter;
                    receiptMedicinesOrdersViewDataGridView.Update();
                    receiptMedicinesOrdersViewDataGridView.Refresh();
                }
            }
        }

        private void archivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ArchivesForm().Show();
        }

        private void addNewMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddMedicineForm().Show();
        }
    }
}

