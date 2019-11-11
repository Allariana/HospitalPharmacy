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


            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";

            ConnectionManager connection = new ConnectionManager();


            if (connection.verifyIfUserIsCorrect(username, password))
            {
                this.Hide();
                new MainPageForm(username).Show();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
