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
        int id;
                
        public GenerateOrderForm(int id)
        {
            this.id = id;

            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();

            //this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
                        
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager connection = ConnectionManager.getInstance();
                connection.insertOrder(id);
                generateOrderViewDataGridView.DataSource = generateOrderViewTableAdapter;
                generateOrderViewDataGridView.Refresh();
                MessageBox.Show("Order completed!");
                //this.priceLabel.Text = (string.Format("{0:0.00}", connection.getPrice().ToString()));
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
            //new MainPageForm(username).Show();
        }

        private void GenerateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            this.generateOrderViewTableAdapter.Fill(this.pharmacyDataSet.GenerateOrderView);

        }
    }
}
