using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AddMedicineForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        
        public AddMedicineForm()
        {
            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "CategoryName";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            DataTable categoryColumn = new DataTable();
            connection.getColumn("Categories", "CategoryName", categoryColumn);
            List<string> list = categoryColumn.Rows.OfType<DataRow>().Select(dr => (string)dr["CategoryName"]).ToList();
            comboBoxColumn.DataSource = list;
            medicinesDataGridView.Columns.Add(comboBoxColumn);
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                row.Cells[8].Value = "Psychotrop";
            }
        }

        private void medicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            medicinesBindingSource.EndEdit();
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

        }

        private void medicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesDataGridView.DataSource;
            bindingSource.Filter = "TradeName like '" + searchTextBox.Text + "%' OR ActiveSubstance like '" + searchTextBox.Text + "%'";
        }

        private void medicinesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*ConnectionManager connection = ConnectionManager.getInstance();
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                String category = row.Cells["CategoryName"].ToString();
                String medicineID = row.Cells["MedicineID"].ToString();
                connection.insertCategory("CategoryID", "Categories", "CategoryName", category, medicineID);
                
            }*/
                //this.Hide();
        }

        private void medicinesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9) // your combo column index
            {
                e.Value = "Psychotrop";
            }
        }
    }
}
