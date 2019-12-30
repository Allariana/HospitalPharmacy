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
    public partial class PackageForm : Form
    {
        string medicineID;
        //int medicineID;
        public PackageForm(string ID)
        {
            InitializeComponent();
            this.medicineID = ID;
            DataTable dataTable = new DataTable();
            ConnectionManager connection = ConnectionManager.getInstance();
            connection.getPackage(dataTable, medicineID);
            packageOfMedicineDataGridView.DataSource = dataTable;
            
        }

        private void packageOfMedicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packageOfMedicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.PackageOfMedicine' table. You can move, or remove it, as needed.
            this.packageOfMedicineTableAdapter.Fill(this.pharmacyDataSet.PackageOfMedicine);
            foreach (DataGridViewRow row in packageOfMedicineDataGridView.Rows)
            {
                int index = packageOfMedicineDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) packageOfMedicineDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void packageOfMedicineDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
