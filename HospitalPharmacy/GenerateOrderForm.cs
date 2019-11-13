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
                
        public GenerateOrderForm()
        {
            InitializeComponent();
            ConnectionManager connection = new ConnectionManager();
            DataTable price = new DataTable();
            connection.getPrice(price);
            this.priceLabel.Text = price.ToString();
            //priceGridView.DataSource = price.ToString();
            try
            {
                pharmacyContext = new PharmacyEntities();
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
                //priceGridView.DataSource = pharmacyContext.TotalPriceView.ToList();
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
            ConnectionManager connection = new ConnectionManager();
            connection.insertOrder();
        }
    }
}
