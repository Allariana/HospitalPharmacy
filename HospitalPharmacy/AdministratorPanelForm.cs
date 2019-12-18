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
    public partial class AdministratorPanelForm : Form
    {
        private string username;
        int userID;
        public AdministratorPanelForm(int userID, String username)
        {
            this.username = username;
            this.userID = userID;
            InitializeComponent();
            UserLabel.Text = username;
        }

        private void AdministratorPanelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.Suppliers);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pharmacyDataSet.Categories);

        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableListBox.SelectedItem.ToString() == "Medicines")
                {
                    new AdministratorMedicinesForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "Categories")
                {
                    new AdministratorCategoriesForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "Departments")
                {
                    new AdministratorDepartmentsForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "Users")
                {
                    new AdministratorUsersForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "User Details")
                {
                    new AdminUserDetailsForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "Suppliers")
                {
                    new AdministratorSuppliersForm().Show();
                }
                else if (tableListBox.SelectedItem.ToString() == "Orders")
                {
                    new AdministratorOrderForm().Show();
                }
                
            }
            catch (NullReferenceException) { 
            
            MessageBox.Show("Choose table!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
