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
    public partial class MedicinesOrderDetailsForm : Form
    {
        string MedicinesOrderId;
        public MedicinesOrderDetailsForm(String MedicinesOrderId)
        {
            this.MedicinesOrderId = MedicinesOrderId;
            InitializeComponent();
            ConnectionManager connection = new ConnectionManager();
            DataTable orderDetails = new DataTable();
            //string columnname = "MedicinesOrderID";
            //string tablename = "MedicineOrderDetails";
            //connection.getTableWithCondition(tablename, columnname, orderDetails, MedicinesOrderId);
            connection.getMedicinesOrderDetails(orderDetails, MedicinesOrderId);
            medicinesOrderDetailsGridView.DataSource = orderDetails;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicinesOrderDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
