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
        bool ifOrderWasGenerate = false;
        public bool ifOrder
        {
            get { return ifOrderWasGenerate; }
        }

        public GenerateOrderForm(int id)
        {
            this.id = id;
            InitializeComponent();
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
                ifOrderWasGenerate = true;
                DialogResult = DialogResult.OK;
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
        }

        private void GenerateOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            generateOrderViewTableAdapter.Fill(pharmacyDataSet.GenerateOrderView);
        }
    }
}
