using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class MainPageForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private int userID;
        private string username;
        public MainPageForm(int userID, String username)
        {
            InitializeComponent();
            var topLeftHeaderCell = currentOrdersViewDataGridView.TopLeftHeaderCell;
            this.username = username;
            this.userID = userID;
            tabControl.TabPages.Clear();
            tabControl.TabPages.Insert(0, currentOrderTabPage);
            UserLabel.Text = username;
        }

        private void MainPagecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.MedicinesOrders' table. You can move, or remove it, as needed.
            this.medicinesOrdersTableAdapter.Fill(this.pharmacyDataSet.MedicinesOrders);
            // TODO: This line of code loads data into the 'pharmacyDataSet.StatisticView' table. You can move, or remove it, as needed.
            this.statisticViewTableAdapter.Fill(this.pharmacyDataSet.StatisticView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.ProfileView' table. You can move, or remove it, as needed.
            profileViewTableAdapter.Fill(pharmacyDataSet.ProfileView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.PharmacistsView' table. You can move, or remove it, as needed.
            pharmacistsViewTableAdapter.Fill(pharmacyDataSet.PharmacistsView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Suppliers' table. You can move, or remove it, as needed.
            suppliersTableAdapter.Fill(pharmacyDataSet.Suppliers);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Departments' table. You can move, or remove it, as needed.
            departmentsTableAdapter.Fill(pharmacyDataSet.Departments);
            receiptMedicinesOrdersViewTableAdapter.Fill(pharmacyDataSet.ReceiptMedicinesOrdersView);
            currentOrdersViewTableAdapter.Fill(pharmacyDataSet.CurrentOrdersView);
            ordersViewTableAdapter.Fill(pharmacyDataSet.OrdersView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            generateOrderViewTableAdapter.Fill(pharmacyDataSet.GenerateOrderView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.MedicinesView' table. You can move, or remove it, as needed.
            medicinesViewTableAdapter.Fill(pharmacyDataSet.MedicinesView);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            medicinesTableAdapter.Fill(pharmacyDataSet.Medicines);
            medicinesOrdersViewTableAdapter.Fill(pharmacyDataSet.MedicinesOrdersView);

            panel.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel3.BackColor = Color.FromArgb(100, 255, 255, 255);
            foreach (DataGridViewRow row in currentOrdersViewDataGridView.Rows)
            {
                int index = currentOrdersViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) currentOrdersViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            foreach (DataGridViewRow row in medicinesViewDataGridView.Rows)
            {
                int index = medicinesViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) medicinesViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
   
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
               

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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
            MainPagecs_Load(null, null);
        }

        private void listOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(currentOrderTabPage);
            MainPagecs_Load(null, null);
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

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void listOfDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTabPage(departmentsPage);
        }

        private void receiptMedicinesOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectionManager connection = ConnectionManager.getInstance();
            switch (MessageBox.Show("Are you sure you want to mark this order as done?", "Confirmation", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    connection.pickUpOrder(receiptMedicinesOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    MainPagecs_Load(null, null);
                    break;
                case DialogResult.No:
                    break;
            }
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
            try
            {
                if (ordersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    new OrderDetailsForm(ordersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
                }
            }
            catch (Exception) { }
        }

        private void completeOrdersViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool enough=false;
            ConnectionManager connection = ConnectionManager.getInstance();
            if (completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                enough = connection.checkIfEnoughMedicines(completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            if (enough == true)
            {
                using (PackagesToIssueForm packagesToIssueForm = new PackagesToIssueForm(int.Parse(completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()), userID))
                {
                    if (packagesToIssueForm.ShowDialog() == DialogResult.OK)
                    {
                        MainPagecs_Load(null, null);
                    }
                }
                //new PackagesToIssueForm(int.Parse(completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()),userID).Show();
            }
            else MessageBox.Show("There is not enough medicines to complete this order!");
            /*
            if (completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int id;
                id = userID;
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.completeOrder(completeOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),id);
                MainPagecs_Load(null, null);
            }*/
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

        private void makeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MakeOrderForm makeOrderForm = new MakeOrderForm(userID))
            {
                if (makeOrderForm.ShowDialog() == DialogResult.OK)
                {
                    MainPagecs_Load(null, null);
                }
            }
        }

        private void generateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GenerateOrderForm generateOrderForm = new GenerateOrderForm(userID))
            {
                if (generateOrderForm.ShowDialog() == DialogResult.OK)
                {
                    MainPagecs_Load(null, null);
                }
            }
        }

        private void archivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ArchivesForm().Show();
        }

        private void addNewMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddMedicineForm addMedicineForm = new AddMedicineForm())
            {
                if (addMedicineForm.ShowDialog() == DialogResult.OK)
                {
                    MainPagecs_Load(null, null);
                }
            }
        }

        private void currentOrdersViewDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (currentOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                new OrderDetailsForm(currentOrdersViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

         private void statisticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openTabPage(statisticTabPage);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesViewDataGridView.DataSource;
            bindingSource.Filter = "TradeName like '" + searchTextBox.Text + "%' OR ActiveSubstance like '" + searchTextBox.Text + "%'";
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesViewDataGridView.DataSource;
            bindingSource.Filter = "TradeName like '" + searchTextBox.Text + "%' OR ActiveSubstance like '" + searchTextBox.Text + "%'";
        }

        private void checkOfExpiredPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExpiredPackagesForm expiredPackagesForm = new ExpiredPackagesForm())
            {
                if (expiredPackagesForm.ShowDialog() == DialogResult.OK)
                {
                    MainPagecs_Load(null, null);
                }
            }
        }
    }
}

