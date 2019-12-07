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
    public partial class ProfileForm : Form
    {
        int id;
        public ProfileForm(int userID)
        {
            id = userID;
            InitializeComponent();
            ConnectionManager connection = ConnectionManager.getInstance();
            lastNameLabel.Text = connection.getRecord("LastName",id);
            firstNameLabel.Text = connection.getRecord("FirstName", id);
            titleLabel.Text = connection.getRecord("Title", id);
            birthLabel.Text = connection.getRecord("BirthDate", id);
            hireLabel.Text = connection.getRecord("HireDate", id);
            addressLabel.Text = connection.getRecord("Address", id);
            phoneLabel.Text = connection.getRecord("Phone", id);
            usernameLabel.Text = connection.getRecord("Username", id);
            emailLabel.Text = connection.getRecord("Email", id);
            //photoPictureBox.Image = connection.GetImage(id);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.ProfileView' table. You can move, or remove it, as needed.
            this.profileViewTableAdapter.Fill(this.pharmacyDataSet.ProfileView);
             

        }

        private void userIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
