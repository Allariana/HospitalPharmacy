using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class MedicinesOrderDetailsForm : Form
    {
        string MedicinesOrderId;
        public MedicinesOrderDetailsForm(String MedicinesOrderId)
        {
            this.MedicinesOrderId = MedicinesOrderId;
            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();
            DataTable orderDetails = new DataTable();
            connection.getMedicinesOrderDetails(orderDetails, MedicinesOrderId);
            medicinesOrderDetailsGridView.DataSource = orderDetails;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicinesOrderDetailsForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in medicinesOrderDetailsGridView.Rows)
            {
                int index = medicinesOrderDetailsGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) medicinesOrderDetailsGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("D:\\Kinga\\Studies\\IV rok\\Semestr 7\\Praca dyplomowa\\Invoices\\" + MedicinesOrderId + ".xlsx");
            }
            catch (Exception)
            {
                MessageBox.Show("This order is not completed. There is no invoice for that.");
            }
        }
    }
}
