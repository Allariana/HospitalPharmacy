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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login";
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            int userID, roleID;
            DataRow dataRow;
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "s";

            ConnectionManager connection = ConnectionManager.getInstance();


            if (connection.verifyIfUserIsCorrect(username, password))
            {
                dataRow = connection.getID(username);
                userID = int.Parse(dataRow[0].ToString());
                roleID = int.Parse(dataRow[1].ToString());
                if(roleID == 1)
                {
                    this.Hide();
                    new AdministratorPanelForm(userID, username).Show();
                }
                if(roleID == 2) {
                    this.Hide();
                    new MainPageForm(userID, username).Show();
                }
                
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
