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
            ConnectionManager connection = ConnectionManager.getInstance();

            this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
                        
            try
            {
                pharmacyContext = new PharmacyEntities();
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
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
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.insertOrder(username);
                MessageBox.Show("Order completed!");
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
                this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPageForm(username).Show();
        }
    }
}
