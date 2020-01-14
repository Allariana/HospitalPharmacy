using System;
using System.Drawing;
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
            medicinesViewTableAdapter.Fill(pharmacyDataSet.MedicinesView);
            foreach (DataGridViewRow row in medicinesViewDataGridView.Rows)
            {
                int index = medicinesViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) medicinesViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
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
                DialogResult = DialogResult.OK;
                MessageBox.Show("Order completed!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values in the basket! Check and correct mistakes!");
            }

        }
                
    }
}

