﻿using System;
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
    public partial class PackagesToIssueForm : Form
    {
        int orderID, userID;
        ConnectionManager connection = ConnectionManager.getInstance();
        ObjectsController objectsController = ObjectsController.getInstance();
        public PackagesToIssueForm(int orderID, int userID)
        {
            this.orderID = orderID;
            this.userID = userID;
            InitializeComponent();
            DataTable packagesDataTable = new DataTable();
            connection.fillPackagesBasket(packagesDataTable, orderID);
            packagesBasketDataGridView.DataSource = packagesDataTable;
        }

        private void PackagesToIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.completeOrder(orderID, userID);
            DialogResult = DialogResult.OK;
        }
    }
}