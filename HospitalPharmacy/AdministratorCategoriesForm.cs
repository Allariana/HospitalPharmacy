using System;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AdministratorCategoriesForm : Form
    {
        public AdministratorCategoriesForm()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            categoriesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(pharmacyDataSet);

        }

        private void AdministratorCategoriesForm_Load(object sender, EventArgs e)
        {
            categoriesTableAdapter.Fill(pharmacyDataSet.Categories);

        }
    }
}
