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
    public partial class AdministratorMedicinesForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        public AdministratorMedicinesForm()
        {
            InitializeComponent();
        }

        private void medicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            medicinesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);

        }

        private void AdministratorMedicinesForm_Load(object sender, EventArgs e)
        {
            categoriesTableAdapter.Fill(pharmacyDataSet.Categories);
            medicinesTableAdapter.Fill(pharmacyDataSet.Medicines);

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = medicinesDataGridView.DataSource;
            bindingSource.Filter = "TradeName like '" + searchTextBox.Text + "%' OR ActiveSubstance like '" + searchTextBox.Text + "%'";
        }

    }

}
