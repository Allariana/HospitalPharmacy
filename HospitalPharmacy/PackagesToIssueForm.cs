﻿using System;
using System.Data;
using System.Drawing;
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
            foreach (DataGridViewRow row in packagesBasketDataGridView.Rows)
            {
                int index = packagesBasketDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) packagesBasketDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            connection.completeOrder(orderID, userID);
            DialogResult = DialogResult.OK;
        }
    }
}
