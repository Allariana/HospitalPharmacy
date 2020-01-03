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
    public partial class OrderDetailsForm : Form
    {
        string OrderId;
        public OrderDetailsForm(String OrderId)
        {
            this.OrderId = OrderId;
            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();
            DataTable orderDetails = new DataTable();
            connection.getOrderDetails(orderDetails, OrderId);
            orderDetailsGridView.DataSource = orderDetails;
            
        }
            private void orderDetailsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderDetailsForm_Load_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in orderDetailsGridView.Rows)
            {
                int index = orderDetailsGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) orderDetailsGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }

        }
    }
}
