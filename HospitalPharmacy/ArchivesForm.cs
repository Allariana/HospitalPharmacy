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
    public partial class ArchivesForm : Form
    {
        public ArchivesForm()
        {
            InitializeComponent();
        }

        private void ArchivesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.OldPackagesView' table. You can move, or remove it, as needed.
            this.oldPackagesViewTableAdapter.Fill(this.pharmacyDataSet.OldPackagesView);

        }
    }
}
