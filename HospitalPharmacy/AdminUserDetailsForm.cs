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
    public partial class AdminUserDetailsForm : Form
    {
        public AdminUserDetailsForm()
        {
            InitializeComponent();
        }

        private void userDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void AdminUserDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.UserDetails' table. You can move, or remove it, as needed.
            this.userDetailsTableAdapter.Fill(this.pharmacyDataSet.UserDetails);

        }
    }
}
