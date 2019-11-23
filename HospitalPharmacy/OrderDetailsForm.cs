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
    }
}
