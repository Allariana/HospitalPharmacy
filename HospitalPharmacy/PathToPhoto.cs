using System;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class PathToPhoto : Form
    {
        public string value
        {
            get { return pathTextBox.Text; }
        }
        public PathToPhoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
