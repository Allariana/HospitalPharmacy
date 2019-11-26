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
    public partial class AmountForm : Form
    {
        public string value
        {
            get { return amountTextBox.Text; }
        }
        public AmountForm(String medicineID)
        {
            InitializeComponent();
            
        }

        private void AmountForm_Load(object sender, EventArgs e)
        {

        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}

