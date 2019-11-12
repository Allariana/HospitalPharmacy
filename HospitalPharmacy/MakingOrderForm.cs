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
    public partial class MakingOrderForm : Form
    {
        public MakingOrderForm()
        {
            InitializeComponent();
            PharmacyEntities pharmacyContext;
            try
            {
                pharmacyContext = new PharmacyEntities();
                medicinesCheckedListBox.DataSource = pharmacyContext.MedicinesViews.ToList();
                //priceGridView.DataSource = pharmacyContext.TotalPriceView.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ConnectionManager connection = new ConnectionManager();
            DataTable tradeNameCombo = new DataTable();
            DataTable doseCombo = new DataTable();
            string columnname = "TradeName";
            //string dosecolumnname = "[Dose(mg)]";
            string tablename = "Medicines";
            //string seronil = "Seronil";
            connection.getTable(tablename, columnname, tradeNameCombo);
            foreach (DataRow row in tradeNameCombo.Rows)
            {
                tradeNameComboBox.Items.Add(row["TradeName"]);
            }
            //if (tradeNameComboBox.SelectedItem.ToString() == null) connection.getTableWithCondition(dosecolumnname, tablename, columnname, "Seronil", doseCombo);
            //else connection.getTableWithCondition(dosecolumnname, tablename, columnname, tradeNameComboBox.SelectedItem.ToString(), doseCombo);
            /*try
            {
                connection.getTableWithCondition(dosecolumnname, tablename, columnname, tradeNameComboBox.SelectedItem.ToString(), doseCombo);
            }
            catch (NullReferenceException)
            {
                connection.getTableWithCondition(dosecolumnname, tablename, columnname, "Seronil", doseCombo);
            }*/
            /*connection.getTableWithCondition(dosecolumnname, tablename, columnname, seronil, doseCombo);
            foreach (DataRow row in tradeNameCombo.Rows)
            {
                doseComboBox.Items.Add(row["[Dose(mg)]"]);
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
