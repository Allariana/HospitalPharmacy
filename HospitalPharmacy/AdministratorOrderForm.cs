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
    public partial class AdministratorOrderForm : Form
    {
        public AdministratorOrderForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void AdministratorOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pharmacyDataSet.Orders);

        }
    }
}
