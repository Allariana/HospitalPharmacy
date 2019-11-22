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
    public partial class MakeOrderForm : Form
    {
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GenerateOrderView' table. You can move, or remove it, as needed.
            this.generateOrderViewTableAdapter.Fill(this.pharmacyDataSet.GenerateOrderView);

        }
    }
}
