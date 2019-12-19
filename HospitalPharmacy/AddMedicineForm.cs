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
    public partial class AddMedicineForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        
        public AddMedicineForm()
        {
            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();
            DataTable categoryColumn = new DataTable();
            connection.getColumn("Categories","CategoryName",categoryColumn);
            List<string> list = categoryColumn.Rows.OfType<DataRow>().Select(dr => (string)dr["CategoryName"]).ToList();
            
            foreach (DataGridViewRow row in medicinesDataGridView.Rows)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(row.Cells["CategoryID"]);
                cell.DataSource = list;
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
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            medicinesTableAdapter.Fill(pharmacyDataSet.Medicines);

        }

        private void medicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesDataGridView.DataSource;
            bindingSource.Filter = "TradeName = '" + searchTextBox.Text + "' OR ActiveSubstance = '" + searchTextBox.Text + "'";
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
