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
    public partial class AdministratorPanelForm : Form
    {
        private string username;
        int userID;
        public AdministratorPanelForm(int userID, String username)
        {
            this.username = username;
            this.userID = userID;
            InitializeComponent();
        }

        private void AdministratorPanelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
