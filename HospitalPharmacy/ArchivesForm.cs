using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class ArchivesForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        public ArchivesForm()
        {
            InitializeComponent();
        }

        private void ArchivesForm_Load(object sender, EventArgs e)
        {
            oldPackagesViewTableAdapter.Fill(pharmacyDataSet.OldPackagesView);
            foreach (DataGridViewRow row in oldPackagesViewDataGridView.Rows)
            {
                int index = oldPackagesViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) oldPackagesViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }

        private void oldPackagesViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bindingSource.DataSource = oldPackagesViewDataGridView.DataSource;
                int sn = int.Parse(searchTextBox.Text);
                bindingSource.Filter = "[SerialNumber(SN)] = " + sn;
            }
            catch (FormatException) { }
        }
    }
}
