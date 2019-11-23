﻿using System;
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
    public partial class MakeOrderForm : Form
    {
        bool changeData = false;
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            this.generateOrderViewTableAdapter.Fill(this.pharmacyDataSet.GenerateOrderView);

        }

        private void MedicinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MedicinesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //new AmountForm().Show();
        }

        private void MedicinesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                
                //new AmountForm((medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value).ToString()).Show();
                using (AmountForm amountForm = new AmountForm(medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    //amountForm.Show();
                    if(amountForm.ShowDialog() == DialogResult.OK)
                       {
                        this.basketGridView.Rows.Add(medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), amountForm.value);
                        //this.basketGridView.
                    }
                    
                }
            }
                //ew AmountForm(int.Parse(medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
        }

        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            //if (medicinesDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
        }
        private void BasketGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changeData = true;
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
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

