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
    public partial class GenerateOrderForm : Form
    {
        PharmacyEntities pharmacyContext;
        string username;
                
        public GenerateOrderForm(string username)
        {
            this.username = username;

            InitializeComponent();
            ConnectionManager connection = new ConnectionManager();
            
            
            this.priceLabel.Text = connection.getPrice().ToString();
            
            try
            {
                pharmacyContext = new PharmacyEntities();
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrdersViews.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = new ConnectionManager();
                connection.insertOrder(username);
                MessageBox.Show("Order completed!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
