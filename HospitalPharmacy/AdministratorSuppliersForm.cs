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
            suppliersTableAdapter.Fill(pharmacyDataSet.Suppliers);

        }

        private void AdministratorSuppliersForm_Load_1(object sender, EventArgs e)
        {
            suppliersTableAdapter1.Fill(pharmacyDataSet1.Suppliers);
            foreach (DataGridViewRow row in suppliersDataGridView1.Rows)
            {
                int index = suppliersDataGridView1.Rows.IndexOf(row);
                if ((index % 2) == 0) suppliersDataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }

        private void suppliersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            suppliersBindingSource1.EndEdit();
            tableAdapterManager1.UpdateAll(pharmacyDataSet1);

        }
    }
}
