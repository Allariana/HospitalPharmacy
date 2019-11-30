using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class MakeOrderForm : Form
    {
        int id;
        ObjectsController objectsController = ObjectsController.getInstance();
        public MakeOrderForm(int id)
        {
            this.id = id;
            InitializeComponent();
            objectsController.addColumn(objectsController.basketDataTable);
            basketGridView.DataSource = objectsController.basketDataTable;
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.MedicinesView' table. You can move, or remove it, as needed.
            this.medicinesViewTableAdapter.Fill(this.pharmacyDataSet.MedicinesView);       
        }

        private void medicinesViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                
                using (AmountForm amountForm = new AmountForm(medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    if(amountForm.ShowDialog() == DialogResult.OK)
                       {
                        objectsController.basketDataTable.Rows.Add(medicinesViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), amountForm.value);
                        basketGridView.DataSource = objectsController.basketDataTable;
                        basketGridView.Refresh();                       
                    }
                    
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.makeOrder(id, objectsController.basketDataTable);
                basketGridView.DataSource = objectsController.basketDataTable;
                basketGridView.Refresh();
                MessageBox.Show("Order completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BasketGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {                            
        }
    }
}

