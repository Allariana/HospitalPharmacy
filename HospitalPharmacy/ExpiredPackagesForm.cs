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
    public partial class ExpiredPackagesForm : Form
    {
        public ExpiredPackagesForm()
        {
            InitializeComponent();
        }

        private void ExpiredPackagesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.ExpiredPackagesView' table. You can move, or remove it, as needed.
            this.expiredPackagesViewTableAdapter.Fill(this.pharmacyDataSet.ExpiredPackagesView);
            foreach (DataGridViewRow row in expiredPackagesViewDataGridView.Rows)
            {
                int index = expiredPackagesViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) expiredPackagesViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.deleteExpiredPackage();
                ExpiredPackagesForm_Load(null, null);
                MessageBox.Show("The packages has been successfully deleted.");
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
