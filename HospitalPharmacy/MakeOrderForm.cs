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
        
        //bool changeData = false;
        ObjectsController objectsController = ObjectsController.getInstance();
        public MakeOrderForm()
        {
            InitializeComponent();
            objectsController.addColumn(objectsController.basketDataTable);
            basketGridView.DataSource = objectsController.basketDataTable;
            /*foreach (DataGridViewColumn column in this.basketGridView.Columns)
            {
                column.ValueType = typeof(int);
            }*/
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
                //ew AmountForm(int.Parse(medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
        }

        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            //if (medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            
            //Adding the Columns.
            /*foreach (DataGridViewColumn column in basketGridView.Columns)
            {
                objectsController.basketDataTable.Columns.Add(column.HeaderText, typeof(String));
            }*/
            /*objectsController.basketDataTable.Columns.Add("MedicineID", typeof(String));
        objectsController.basketDataTable.Columns.Add("Amount", typeof(String));
        //Adding the Rows.
        /*foreach (DataGridViewRow row in basketGridView.Rows)
        {
            if (row == null) basketGridView.Rows.Remove(row);
        }*/

            /*
            foreach (DataGridViewRow row in basketGridView.Rows)
            {
                objectsController.basketDataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        objectsController.basketDataTable.Rows[objectsController.basketDataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                    catch (NullReferenceException) { }
                }
            }
            
            ConnectionManager connection = ConnectionManager.getInstance();
            connection.makeOrder(objectsController.basketDataTable);*/
        }
        private void BasketGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            
            /*
            //Adding the Columns.
            foreach (DataGridViewColumn column in basketGridView.Columns)
            {
                objectsController.basketDataTable.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in basketGridView.Rows)
            {
                objectsController.basketDataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    objectsController.basketDataTable.Rows[objectsController.basketDataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            /*switch (MessageBox.Show("Do you want to save basket?", "Message", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    try
                    {
                        
                        MessageBox.Show("Saved", "Message");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Failed" + exc.Message);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            //this.basketGridView.U
            //if (!changeData)MessageBox.Show("Nothing to save");
            /*else
            {
                switch (MessageBox.Show("Do you want to save basket?", "Message", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        try
                        {
                            this.Validate();
                            this.basketGridView.EndEdit();
                            this.basketGridView.Update();
                            //this.pharmacyDataSet.Medicines.End
                            //    db.Dispose();
                            MessageBox.Show("Saved", "Message");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Failed" + exc.Message);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }*/

        }

        


        /*private void saveButton_Click(object sender, EventArgs e)
{
if (changeData==false) MessageBox.Show("Nothing to save");
switch (MessageBox.Show("Do you want to save basket?", "Message", MessageBoxButtons.YesNo))
{
case DialogResult.Yes:
  try
  {
      this.Validate();
      this.basketGridView.EndEdit();

      //this.pharmacyDataSet.Medicines.End
      //    db.Dispose();
      MessageBox.Show("Saved", "Message");
  }
  catch (Exception exc)
  {
      MessageBox.Show("Failed" + exc.Message);
  }
  break;
case DialogResult.No:
  break;
}
}*/


    }
}

