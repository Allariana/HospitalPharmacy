using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AddMedicine : Form
    {
        BindingSource bindingSource = new BindingSource();
        ConnectionManager connection = ConnectionManager.getInstance();
        public AddMedicine()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn supplierComboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Category Name";
            supplierComboBoxColumn.HeaderText = "Company Name";
            comboBoxColumn.Width = 100;
            supplierComboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            supplierComboBoxColumn.Name = "supplierComboBoxColumn";
            DataTable categoryColumn = new DataTable();
            DataTable supplierColumn = new DataTable();
            connection.getColumn("Categories", "CategoryName", categoryColumn);
            connection.getColumn("Suppliers", "CompanyName", supplierColumn);
            List<string> list = categoryColumn.Rows.OfType<DataRow>().Select(dr => (string)dr["CategoryName"]).ToList();
            List<string> supplierList = supplierColumn.Rows.OfType<DataRow>().Select(dr => (string)dr["CompanyName"]).ToList();
            comboBoxColumn.DataSource = list;
            supplierComboBoxColumn.DataSource = supplierList;
            medicinesDataGridView.Columns.Add(comboBoxColumn);
            medicinesDataGridView.Columns.Add(supplierComboBoxColumn);
            

        }

        private void medicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            medicinesBindingSource.EndEdit();
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    connection.update("CategoryID", "Categories", "CategoryName", row.Cells[9].Value.ToString(), row.Cells[0].Value.ToString(), "Medicines", "MedicineID");
                }
                catch (Exception) { }
            }
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    
                    connection.update("SupplierID", "Suppliers", "CompanyName", row.Cells[10].Value.ToString(), row.Cells[0].Value.ToString(), "Medicines", "MedicineID");
                }
                catch (Exception) { }
            }
                      
            tableAdapterManager.UpdateAll(pharmacyDataSet);
            DialogResult = DialogResult.OK;

        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            medicinesTableAdapter.Fill(pharmacyDataSet.Medicines);
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                int index = medicinesDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) medicinesDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    String id = row.Cells[5].Value.ToString();
                    String categoryName = connection.getRecordWithCondition("CategoryName", "Categories", "CategoryID", int.Parse(id));
                    row.Cells[9].Value = categoryName;
                }
                catch (Exception) { }
            }
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    String id = row.Cells[8].Value.ToString();
                    String supplierName = connection.getRecordWithCondition("CompanyName", "Suppliers", "SupplierID", int.Parse(id));
                    row.Cells[10].Value = supplierName;
                }
                catch (Exception) { }
            }
        }

        private void medicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesDataGridView.DataSource;
            bindingSource.Filter = "TradeName like '" + searchTextBox.Text + "%' OR ActiveSubstance like '" + searchTextBox.Text + "%'";
            AddMedicineForm_Load(null, null);
        }

        private void medicinesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void medicinesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                       
            /*foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    String id = row.Cells[5].Value.ToString();
                    String categoryName = connection.getRecordWithCondition("CategoryName", "Categories", "CategoryID", int.Parse(id));
                    row.Cells[9].Value = categoryName;
                }
                catch (Exception) { }
            }
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                try
                {
                    String id = row.Cells[8].Value.ToString();
                    String supplierName = connection.getRecordWithCondition("CompanyName", "Suppliers", "SupplierID", int.Parse(id));
                    row.Cells[10].Value = supplierName;
                }
                catch (Exception) { }
            }*/
        }

        
    }
}
