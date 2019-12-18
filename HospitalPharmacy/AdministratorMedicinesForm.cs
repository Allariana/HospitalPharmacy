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
            this.Validate();
            this.medicinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void AdministratorMedicinesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pharmacyDataSet.Categories);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bindingSource.DataSource = medicinesDataGridView.DataSource;       
            bindingSource.Filter = "TradeName = '" + searchTextBox.Text + "' OR ActiveSubstance = '" + searchTextBox.Text + "'";         
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /*private void viewAllButton_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = pharmacyDataSet.Medicines;
            medicinesDataGridView.DataSource = bindingSource;


        }*/
    }

}
