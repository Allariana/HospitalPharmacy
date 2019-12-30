using System;
using System.Drawing;
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
                GenerateOrderForm_Load(null, null);
                MessageBox.Show("Order completed!");
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
            generateOrderViewTableAdapter.Fill(pharmacyDataSet.GenerateOrderView);
            foreach (DataGridViewRow row in generateOrderViewDataGridView.Rows)
            {
                int index = generateOrderViewDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) generateOrderViewDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
    }
}
