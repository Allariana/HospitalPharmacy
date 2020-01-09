using System;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AdminUserDetailsForm : Form
    {
        ConnectionManager connection = ConnectionManager.getInstance();
        public AdminUserDetailsForm()
        {
            InitializeComponent();
        }

        private void userDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            userDetailsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);
        }

        private void AdminUserDetailsForm_Load(object sender, EventArgs e)
        {
            userDetailsTableAdapter.Fill(pharmacyDataSet.UserDetails);
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            using (PathToPhoto pathToPhoto = new PathToPhoto())
            {
                if (pathToPhoto.ShowDialog() == DialogResult.OK)
                {
                    connection.insertPhoto(pathToPhoto.value, bindingNavigatorPositionItem.ToString());
                    AdminUserDetailsForm_Load(null, null);
                }
            }
        }
    }
}
