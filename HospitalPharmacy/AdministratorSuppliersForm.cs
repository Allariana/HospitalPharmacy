using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AdministratorSuppliersForm : Form
    {
        public AdministratorSuppliersForm()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            suppliersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);

        }

        private void AdministratorSuppliersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.Suppliers);

        }

        private void AdministratorSuppliersForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter1.Fill(this.pharmacyDataSet1.Suppliers);
            foreach (DataGridViewRow row in suppliersDataGridView1.Rows)
            {
                int index = suppliersDataGridView1.Rows.IndexOf(row);
                if ((index % 2) == 0) suppliersDataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }

        private void suppliersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.pharmacyDataSet1);

        }

        private void suppliersDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdministratorSuppliersForm_Load_1(null, null);
        }
    }
}
