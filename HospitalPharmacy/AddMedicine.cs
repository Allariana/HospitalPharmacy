using System;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'pharmacyDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.Suppliers);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pharmacyDataSet.Categories);
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
            AddMedicineForm_Load(null, null);
        }

        private void medicinesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void medicinesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                       
        }

        
    }
}
