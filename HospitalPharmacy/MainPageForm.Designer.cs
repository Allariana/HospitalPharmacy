﻿namespace HospitalPharmacy
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentsAndOrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseAndShoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPurchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptOfOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPharmacistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new HospitalPharmacy.PharmacyDataSet();
            this.currentOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesOrdersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMedicinesOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacistsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UserLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profileButton = new System.Windows.Forms.Button();
            this.generateOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesTableAdapter();
            this.medicinesViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesViewTableAdapter();
            this.generateOrderViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter();
            this.departmentsTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.DepartmentsTableAdapter();
            this.ordersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.OrdersViewTableAdapter();
            this.tableAdapterManager = new HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.medicinesOrdersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesOrdersViewTableAdapter();
            this.currentOrdersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.CurrentOrdersViewTableAdapter();
            this.receiptMedicinesOrdersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.ReceiptMedicinesOrdersViewTableAdapter();
            this.suppliersTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.SuppliersTableAdapter();
            this.pharmacistsViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.PharmacistsViewTableAdapter();
            this.profileViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.ProfileViewTableAdapter();
            this.pharmacistTabPage = new System.Windows.Forms.TabPage();
            this.pharmacistsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersTabPage = new System.Windows.Forms.TabPage();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyOrdersTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ordersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.currentOrderTabPage = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.currentOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.recepitOrderTabPage = new System.Windows.Forms.TabPage();
            this.receiptMedicinesOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDetailsPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.medicinesOrdersViewDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.departmentsGridView = new System.Windows.Forms.DataGridView();
            this.ordynatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.completeOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.generateButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.medicinesViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivesButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.pharmacistTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsViewDataGridView)).BeginInit();
            this.suppliersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.historyOrdersTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataGridView)).BeginInit();
            this.currentOrderTabPage.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewDataGridView)).BeginInit();
            this.recepitOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewDataGridView)).BeginInit();
            this.purchaseDetailsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView1)).BeginInit();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
            this.orderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersViewDataGridView)).BeginInit();
            this.stockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(650, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed in as:";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutButton.Location = new System.Drawing.Point(928, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 27);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsAndOrToolStripMenuItem,
            this.warehouseAndShoppingToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.pharmacistsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departmentsAndOrToolStripMenuItem
            // 
            this.departmentsAndOrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfOrdersToolStripMenuItem,
            this.orderDetailsToolStripMenuItem,
            this.completeOrderToolStripMenuItem,
            this.listOfDepartmentsToolStripMenuItem});
            this.departmentsAndOrToolStripMenuItem.Name = "departmentsAndOrToolStripMenuItem";
            this.departmentsAndOrToolStripMenuItem.Size = new System.Drawing.Size(186, 23);
            this.departmentsAndOrToolStripMenuItem.Text = "Departments and Orders";
            this.departmentsAndOrToolStripMenuItem.Click += new System.EventHandler(this.departmentsAndOrToolStripMenuItem_Click);
            // 
            // listOfOrdersToolStripMenuItem
            // 
            this.listOfOrdersToolStripMenuItem.Name = "listOfOrdersToolStripMenuItem";
            this.listOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.listOfOrdersToolStripMenuItem.Text = "Current Orders";
            this.listOfOrdersToolStripMenuItem.Click += new System.EventHandler(this.listOfOrdersToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.orderDetailsToolStripMenuItem.Text = "History of orders";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // completeOrderToolStripMenuItem
            // 
            this.completeOrderToolStripMenuItem.Name = "completeOrderToolStripMenuItem";
            this.completeOrderToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.completeOrderToolStripMenuItem.Text = "Complete Order";
            this.completeOrderToolStripMenuItem.Click += new System.EventHandler(this.completeOrderToolStripMenuItem_Click);
            // 
            // listOfDepartmentsToolStripMenuItem
            // 
            this.listOfDepartmentsToolStripMenuItem.Name = "listOfDepartmentsToolStripMenuItem";
            this.listOfDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.listOfDepartmentsToolStripMenuItem.Text = "List of departments";
            this.listOfDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.listOfDepartmentsToolStripMenuItem_Click);
            // 
            // warehouseAndShoppingToolStripMenuItem
            // 
            this.warehouseAndShoppingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inStockToolStripMenuItem,
            this.listOfPurchaseOrdersToolStripMenuItem,
            this.receiptOfOrdersToolStripMenuItem});
            this.warehouseAndShoppingToolStripMenuItem.Name = "warehouseAndShoppingToolStripMenuItem";
            this.warehouseAndShoppingToolStripMenuItem.Size = new System.Drawing.Size(189, 23);
            this.warehouseAndShoppingToolStripMenuItem.Text = "Warehouse and shopping";
            // 
            // inStockToolStripMenuItem
            // 
            this.inStockToolStripMenuItem.Name = "inStockToolStripMenuItem";
            this.inStockToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.inStockToolStripMenuItem.Text = "Warehouse";
            this.inStockToolStripMenuItem.Click += new System.EventHandler(this.inStockToolStripMenuItem_Click);
            // 
            // listOfPurchaseOrdersToolStripMenuItem
            // 
            this.listOfPurchaseOrdersToolStripMenuItem.Name = "listOfPurchaseOrdersToolStripMenuItem";
            this.listOfPurchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.listOfPurchaseOrdersToolStripMenuItem.Text = "List of purchase orders";
            this.listOfPurchaseOrdersToolStripMenuItem.Click += new System.EventHandler(this.listOfPurchaseOrdersToolStripMenuItem_Click);
            // 
            // receiptOfOrdersToolStripMenuItem
            // 
            this.receiptOfOrdersToolStripMenuItem.Name = "receiptOfOrdersToolStripMenuItem";
            this.receiptOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.receiptOfOrdersToolStripMenuItem.Text = "Receipt of orders";
            this.receiptOfOrdersToolStripMenuItem.Click += new System.EventHandler(this.receiptOfOrdersToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // listOfSuppliersToolStripMenuItem
            // 
            this.listOfSuppliersToolStripMenuItem.Name = "listOfSuppliersToolStripMenuItem";
            this.listOfSuppliersToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.listOfSuppliersToolStripMenuItem.Text = "List of suppliers";
            this.listOfSuppliersToolStripMenuItem.Click += new System.EventHandler(this.listOfSuppliersToolStripMenuItem_Click);
            // 
            // pharmacistsToolStripMenuItem
            // 
            this.pharmacistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfPharmacistsToolStripMenuItem});
            this.pharmacistsToolStripMenuItem.Name = "pharmacistsToolStripMenuItem";
            this.pharmacistsToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.pharmacistsToolStripMenuItem.Text = "Pharmacists";
            // 
            // listOfPharmacistsToolStripMenuItem
            // 
            this.listOfPharmacistsToolStripMenuItem.Name = "listOfPharmacistsToolStripMenuItem";
            this.listOfPharmacistsToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.listOfPharmacistsToolStripMenuItem.Text = "List of Pharmacists";
            this.listOfPharmacistsToolStripMenuItem.Click += new System.EventHandler(this.listOfPharmacistsToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Location = new System.Drawing.Point(1014, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 27);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentOrdersViewBindingSource
            // 
            this.currentOrdersViewBindingSource.DataMember = "CurrentOrdersView";
            this.currentOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesOrdersViewBindingSource1
            // 
            this.medicinesOrdersViewBindingSource1.DataMember = "MedicinesOrdersView";
            this.medicinesOrdersViewBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // medicinesViewBindingSource
            // 
            this.medicinesViewBindingSource.DataMember = "MedicinesView";
            this.medicinesViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesOrdersViewBindingSource
            // 
            this.medicinesOrdersViewBindingSource.DataMember = "MedicinesOrdersView";
            this.medicinesOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // receiptMedicinesOrdersViewBindingSource
            // 
            this.receiptMedicinesOrdersViewBindingSource.DataMember = "ReceiptMedicinesOrdersView";
            this.receiptMedicinesOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataMember = "OrdersView";
            this.ordersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // profileViewBindingSource
            // 
            this.profileViewBindingSource.DataMember = "ProfileView";
            this.profileViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacistsViewBindingSource
            // 
            this.pharmacistsViewBindingSource.DataMember = "PharmacistsView";
            this.pharmacistsViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserLabel.Location = new System.Drawing.Point(740, 7);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 19);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "Username";
            // 
            // profileButton
            // 
            this.profileButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profileButton.Location = new System.Drawing.Point(826, 4);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(96, 26);
            this.profileButton.TabIndex = 9;
            this.profileButton.Text = "Your Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // generateOrderViewBindingSource
            // 
            this.generateOrderViewBindingSource.DataMember = "GenerateOrderView";
            this.generateOrderViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesViewTableAdapter
            // 
            this.medicinesViewTableAdapter.ClearBeforeFill = true;
            // 
            // generateOrderViewTableAdapter
            // 
            this.generateOrderViewTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersViewTableAdapter
            // 
            this.ordersViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.MedicineOrderDetailsTableAdapter = null;
            this.tableAdapterManager.MedicinesOrdersTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PackageOfMedicineTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDetailsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // medicinesOrdersViewTableAdapter
            // 
            this.medicinesOrdersViewTableAdapter.ClearBeforeFill = true;
            // 
            // currentOrdersViewTableAdapter
            // 
            this.currentOrdersViewTableAdapter.ClearBeforeFill = true;
            // 
            // receiptMedicinesOrdersViewTableAdapter
            // 
            this.receiptMedicinesOrdersViewTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacistsViewTableAdapter
            // 
            this.pharmacistsViewTableAdapter.ClearBeforeFill = true;
            // 
            // profileViewTableAdapter
            // 
            this.profileViewTableAdapter.ClearBeforeFill = true;
            // 
            // pharmacistTabPage
            // 
            this.pharmacistTabPage.Controls.Add(this.pharmacistsViewDataGridView);
            this.pharmacistTabPage.Location = new System.Drawing.Point(4, 26);
            this.pharmacistTabPage.Name = "pharmacistTabPage";
            this.pharmacistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pharmacistTabPage.Size = new System.Drawing.Size(1075, 544);
            this.pharmacistTabPage.TabIndex = 12;
            this.pharmacistTabPage.Text = "Pharmacists";
            this.pharmacistTabPage.UseVisualStyleBackColor = true;
            // 
            // pharmacistsViewDataGridView
            // 
            this.pharmacistsViewDataGridView.AllowUserToAddRows = false;
            this.pharmacistsViewDataGridView.AllowUserToDeleteRows = false;
            this.pharmacistsViewDataGridView.AutoGenerateColumns = false;
            this.pharmacistsViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.pharmacistsViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacistsViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57});
            this.pharmacistsViewDataGridView.DataSource = this.pharmacistsViewBindingSource;
            this.pharmacistsViewDataGridView.Location = new System.Drawing.Point(15, 17);
            this.pharmacistsViewDataGridView.Name = "pharmacistsViewDataGridView";
            this.pharmacistsViewDataGridView.ReadOnly = true;
            this.pharmacistsViewDataGridView.Size = new System.Drawing.Size(643, 509);
            this.pharmacistsViewDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn57.HeaderText = "Email";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn56.HeaderText = "Username";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn55.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn54.HeaderText = "Title";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn53.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn52.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // suppliersTabPage
            // 
            this.suppliersTabPage.Controls.Add(this.suppliersDataGridView);
            this.suppliersTabPage.Location = new System.Drawing.Point(4, 26);
            this.suppliersTabPage.Name = "suppliersTabPage";
            this.suppliersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.suppliersTabPage.Size = new System.Drawing.Size(1075, 544);
            this.suppliersTabPage.TabIndex = 10;
            this.suppliersTabPage.Text = "Suppliers";
            this.suppliersTabPage.UseVisualStyleBackColor = true;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AllowUserToDeleteRows = false;
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(22, 22);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            this.suppliersDataGridView.Size = new System.Drawing.Size(545, 503);
            this.suppliersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "HomePage";
            this.dataGridViewTextBoxColumn51.HeaderText = "HomePage";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn50.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn49.HeaderText = "Address";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn48.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn47.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Visible = false;
            // 
            // historyOrdersTabPage
            // 
            this.historyOrdersTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyOrdersTabPage.BackgroundImage")));
            this.historyOrdersTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyOrdersTabPage.Controls.Add(this.label4);
            this.historyOrdersTabPage.Controls.Add(this.panel3);
            this.historyOrdersTabPage.Location = new System.Drawing.Point(4, 26);
            this.historyOrdersTabPage.Name = "historyOrdersTabPage";
            this.historyOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyOrdersTabPage.Size = new System.Drawing.Size(1075, 544);
            this.historyOrdersTabPage.TabIndex = 9;
            this.historyOrdersTabPage.Text = "History of orders";
            this.historyOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ordersViewDataGridView);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 544);
            this.panel3.TabIndex = 5;
            // 
            // ordersViewDataGridView
            // 
            this.ordersViewDataGridView.AllowUserToAddRows = false;
            this.ordersViewDataGridView.AllowUserToDeleteRows = false;
            this.ordersViewDataGridView.AutoGenerateColumns = false;
            this.ordersViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40});
            this.ordersViewDataGridView.DataSource = this.ordersViewBindingSource;
            this.ordersViewDataGridView.Location = new System.Drawing.Point(218, 54);
            this.ordersViewDataGridView.Name = "ordersViewDataGridView";
            this.ordersViewDataGridView.ReadOnly = true;
            this.ordersViewDataGridView.Size = new System.Drawing.Size(643, 484);
            this.ordersViewDataGridView.TabIndex = 0;
            this.ordersViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "WhoIssued";
            this.dataGridViewTextBoxColumn40.HeaderText = "WhoIssued";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn39.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn38.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn37.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn36.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn35.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Double click on record to check order details:";
            // 
            // currentOrderTabPage
            // 
            this.currentOrderTabPage.BackColor = System.Drawing.Color.Transparent;
            this.currentOrderTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("currentOrderTabPage.BackgroundImage")));
            this.currentOrderTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentOrderTabPage.Controls.Add(this.panel);
            this.currentOrderTabPage.Location = new System.Drawing.Point(4, 26);
            this.currentOrderTabPage.Name = "currentOrderTabPage";
            this.currentOrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.currentOrderTabPage.Size = new System.Drawing.Size(1075, 544);
            this.currentOrderTabPage.TabIndex = 8;
            this.currentOrderTabPage.Text = "Current orders";
            this.currentOrderTabPage.Click += new System.EventHandler(this.currentOrderTabPage_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.currentOrdersViewDataGridView);
            this.panel.Location = new System.Drawing.Point(-4, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1083, 550);
            this.panel.TabIndex = 4;
            // 
            // currentOrdersViewDataGridView
            // 
            this.currentOrdersViewDataGridView.AllowUserToAddRows = false;
            this.currentOrdersViewDataGridView.AllowUserToDeleteRows = false;
            this.currentOrdersViewDataGridView.AutoGenerateColumns = false;
            this.currentOrdersViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currentOrdersViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentOrdersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrdersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.currentOrdersViewDataGridView.DataSource = this.currentOrdersViewBindingSource;
            this.currentOrdersViewDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentOrdersViewDataGridView.Location = new System.Drawing.Point(278, 48);
            this.currentOrdersViewDataGridView.Name = "currentOrdersViewDataGridView";
            this.currentOrdersViewDataGridView.ReadOnly = true;
            this.currentOrdersViewDataGridView.Size = new System.Drawing.Size(532, 476);
            this.currentOrdersViewDataGridView.TabIndex = 0;
            this.currentOrdersViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentOrdersViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "WhoIssued";
            this.dataGridViewTextBoxColumn34.HeaderText = "WhoIssued";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn33.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn32.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn31.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn30.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn29.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(304, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Double click on record to check order details:";
            // 
            // recepitOrderTabPage
            // 
            this.recepitOrderTabPage.Controls.Add(this.receiptMedicinesOrdersViewDataGridView);
            this.recepitOrderTabPage.Location = new System.Drawing.Point(4, 26);
            this.recepitOrderTabPage.Name = "recepitOrderTabPage";
            this.recepitOrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recepitOrderTabPage.Size = new System.Drawing.Size(1075, 544);
            this.recepitOrderTabPage.TabIndex = 7;
            this.recepitOrderTabPage.Text = "Receipt of orders";
            this.recepitOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // receiptMedicinesOrdersViewDataGridView
            // 
            this.receiptMedicinesOrdersViewDataGridView.AllowUserToAddRows = false;
            this.receiptMedicinesOrdersViewDataGridView.AllowUserToDeleteRows = false;
            this.receiptMedicinesOrdersViewDataGridView.AutoGenerateColumns = false;
            this.receiptMedicinesOrdersViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receiptMedicinesOrdersViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.receiptMedicinesOrdersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptMedicinesOrdersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.receiptMedicinesOrdersViewDataGridView.DataSource = this.receiptMedicinesOrdersViewBindingSource;
            this.receiptMedicinesOrdersViewDataGridView.Location = new System.Drawing.Point(66, 17);
            this.receiptMedicinesOrdersViewDataGridView.Name = "receiptMedicinesOrdersViewDataGridView";
            this.receiptMedicinesOrdersViewDataGridView.ReadOnly = true;
            this.receiptMedicinesOrdersViewDataGridView.Size = new System.Drawing.Size(876, 521);
            this.receiptMedicinesOrdersViewDataGridView.TabIndex = 0;
            this.receiptMedicinesOrdersViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptMedicinesOrdersViewDataGridView_CellContentClick);
            this.receiptMedicinesOrdersViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptMedicinesOrdersViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "WhoOrdered";
            this.dataGridViewTextBoxColumn28.HeaderText = "WhoOrdered";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn27.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn26.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn25.HeaderText = "Price";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn24.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn23.HeaderText = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // purchaseDetailsPage
            // 
            this.purchaseDetailsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchaseDetailsPage.BackgroundImage")));
            this.purchaseDetailsPage.Controls.Add(this.medicinesOrdersViewDataGridView1);
            this.purchaseDetailsPage.Controls.Add(this.panel1);
            this.purchaseDetailsPage.Location = new System.Drawing.Point(4, 26);
            this.purchaseDetailsPage.Name = "purchaseDetailsPage";
            this.purchaseDetailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.purchaseDetailsPage.Size = new System.Drawing.Size(1075, 544);
            this.purchaseDetailsPage.TabIndex = 6;
            this.purchaseDetailsPage.Text = "Purchase Orders";
            this.purchaseDetailsPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 548);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(328, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double click on record to check order details:";
            // 
            // medicinesOrdersViewDataGridView1
            // 
            this.medicinesOrdersViewDataGridView1.AllowUserToAddRows = false;
            this.medicinesOrdersViewDataGridView1.AllowUserToDeleteRows = false;
            this.medicinesOrdersViewDataGridView1.AutoGenerateColumns = false;
            this.medicinesOrdersViewDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrdersViewDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicinesOrdersViewDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.medicinesOrdersViewDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrdersViewDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.medicinesOrdersViewDataGridView1.DataSource = this.medicinesOrdersViewBindingSource;
            this.medicinesOrdersViewDataGridView1.Location = new System.Drawing.Point(228, 47);
            this.medicinesOrdersViewDataGridView1.Name = "medicinesOrdersViewDataGridView1";
            this.medicinesOrdersViewDataGridView1.ReadOnly = true;
            this.medicinesOrdersViewDataGridView1.Size = new System.Drawing.Size(654, 473);
            this.medicinesOrdersViewDataGridView1.TabIndex = 0;
            this.medicinesOrdersViewDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicinesOrdersViewDataGridView1_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "WhoOrdered";
            this.dataGridViewTextBoxColumn22.HeaderText = "WhoOrdered";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn21.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn20.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn19.HeaderText = "Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn17.HeaderText = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // departmentsPage
            // 
            this.departmentsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("departmentsPage.BackgroundImage")));
            this.departmentsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.departmentsPage.Controls.Add(this.departmentsGridView);
            this.departmentsPage.Controls.Add(this.panel2);
            this.departmentsPage.Location = new System.Drawing.Point(4, 26);
            this.departmentsPage.Name = "departmentsPage";
            this.departmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsPage.Size = new System.Drawing.Size(1075, 544);
            this.departmentsPage.TabIndex = 1;
            this.departmentsPage.Text = "Departments";
            this.departmentsPage.UseVisualStyleBackColor = true;
            this.departmentsPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 544);
            this.panel2.TabIndex = 1;
            // 
            // departmentsGridView
            // 
            this.departmentsGridView.AllowUserToAddRows = false;
            this.departmentsGridView.AllowUserToDeleteRows = false;
            this.departmentsGridView.AutoGenerateColumns = false;
            this.departmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.departmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.ordynatorNameDataGridViewTextBoxColumn});
            this.departmentsGridView.DataSource = this.departmentsBindingSource;
            this.departmentsGridView.Location = new System.Drawing.Point(279, 22);
            this.departmentsGridView.Name = "departmentsGridView";
            this.departmentsGridView.ReadOnly = true;
            this.departmentsGridView.Size = new System.Drawing.Size(504, 516);
            this.departmentsGridView.TabIndex = 0;
            // 
            // ordynatorNameDataGridViewTextBoxColumn
            // 
            this.ordynatorNameDataGridViewTextBoxColumn.DataPropertyName = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.HeaderText = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.Name = "ordynatorNameDataGridViewTextBoxColumn";
            this.ordynatorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderTabPage
            // 
            this.orderTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderTabPage.BackgroundImage")));
            this.orderTabPage.Controls.Add(this.label5);
            this.orderTabPage.Controls.Add(this.completeOrdersViewDataGridView);
            this.orderTabPage.Location = new System.Drawing.Point(4, 26);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(1075, 544);
            this.orderTabPage.TabIndex = 5;
            this.orderTabPage.Text = "Complete order";
            this.orderTabPage.UseVisualStyleBackColor = true;
            this.orderTabPage.Click += new System.EventHandler(this.orderTabPage_Click);
            // 
            // completeOrdersViewDataGridView
            // 
            this.completeOrdersViewDataGridView.AllowUserToAddRows = false;
            this.completeOrdersViewDataGridView.AllowUserToDeleteRows = false;
            this.completeOrdersViewDataGridView.AutoGenerateColumns = false;
            this.completeOrdersViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.completeOrdersViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.completeOrdersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completeOrdersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46});
            this.completeOrdersViewDataGridView.DataSource = this.currentOrdersViewBindingSource;
            this.completeOrdersViewDataGridView.Location = new System.Drawing.Point(180, 70);
            this.completeOrdersViewDataGridView.Name = "completeOrdersViewDataGridView";
            this.completeOrdersViewDataGridView.ReadOnly = true;
            this.completeOrdersViewDataGridView.Size = new System.Drawing.Size(687, 440);
            this.completeOrdersViewDataGridView.TabIndex = 8;
            this.completeOrdersViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.completeOrdersViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "WhoIssued";
            this.dataGridViewTextBoxColumn46.HeaderText = "WhoIssued";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn45.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn44.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn43.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn42.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn41.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(284, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Double click on record to complete order:";
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.archivesButton);
            this.stockPage.Controls.Add(this.medicinesViewDataGridView);
            this.stockPage.Controls.Add(this.makeOrderButton);
            this.stockPage.Controls.Add(this.generateButton);
            this.stockPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stockPage.Location = new System.Drawing.Point(4, 26);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(1075, 544);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Warehouse";
            this.stockPage.UseVisualStyleBackColor = true;
            this.stockPage.Click += new System.EventHandler(this.stockPage_Click);
            // 
            // generateButton
            // 
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.generateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(707, 461);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(163, 46);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate order";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeOrderButton.Location = new System.Drawing.Point(467, 461);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(140, 46);
            this.makeOrderButton.TabIndex = 8;
            this.makeOrderButton.Text = "Make order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // medicinesViewDataGridView
            // 
            this.medicinesViewDataGridView.AllowUserToAddRows = false;
            this.medicinesViewDataGridView.AllowUserToDeleteRows = false;
            this.medicinesViewDataGridView.AutoGenerateColumns = false;
            this.medicinesViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicinesViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicinesViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.medicinesViewDataGridView.DataSource = this.medicinesViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicinesViewDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.medicinesViewDataGridView.Location = new System.Drawing.Point(13, 16);
            this.medicinesViewDataGridView.Name = "medicinesViewDataGridView";
            this.medicinesViewDataGridView.ReadOnly = true;
            this.medicinesViewDataGridView.Size = new System.Drawing.Size(1041, 409);
            this.medicinesViewDataGridView.TabIndex = 8;
            this.medicinesViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicinesViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn10.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn9.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RequiredQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "RequiredQuantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dose(mg)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dose(mg)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActiveSubstance";
            this.dataGridViewTextBoxColumn3.HeaderText = "ActiveSubstance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TradeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TradeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MedicineID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MedicineID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // archivesButton
            // 
            this.archivesButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.archivesButton.Location = new System.Drawing.Point(214, 461);
            this.archivesButton.Name = "archivesButton";
            this.archivesButton.Size = new System.Drawing.Size(140, 46);
            this.archivesButton.TabIndex = 9;
            this.archivesButton.Text = "Archives";
            this.archivesButton.UseVisualStyleBackColor = true;
            this.archivesButton.Click += new System.EventHandler(this.archivesButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.orderTabPage);
            this.tabControl.Controls.Add(this.departmentsPage);
            this.tabControl.Controls.Add(this.purchaseDetailsPage);
            this.tabControl.Controls.Add(this.recepitOrderTabPage);
            this.tabControl.Controls.Add(this.currentOrderTabPage);
            this.tabControl.Controls.Add(this.historyOrdersTabPage);
            this.tabControl.Controls.Add(this.suppliersTabPage);
            this.tabControl.Controls.Add(this.pharmacistTabPage);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(15, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1083, 574);
            this.tabControl.TabIndex = 5;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 616);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPageForm";
            this.Text = "PharmKing";
            this.Load += new System.EventHandler(this.MainPagecs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.pharmacistTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsViewDataGridView)).EndInit();
            this.suppliersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.historyOrdersTabPage.ResumeLayout(false);
            this.historyOrdersTabPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewDataGridView)).EndInit();
            this.currentOrderTabPage.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewDataGridView)).EndInit();
            this.recepitOrderTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewDataGridView)).EndInit();
            this.purchaseDetailsPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView1)).EndInit();
            this.departmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
            this.orderTabPage.ResumeLayout(false);
            this.orderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrdersViewDataGridView)).EndInit();
            this.stockPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentsAndOrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseAndShoppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inStockToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button exitButton;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private PharmacyDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.BindingSource medicinesViewBindingSource;
        private PharmacyDataSetTableAdapters.MedicinesViewTableAdapter medicinesViewTableAdapter;
        private System.Windows.Forms.BindingSource generateOrderViewBindingSource;
        private PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter generateOrderViewTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private PharmacyDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource medicinesOrdersViewBindingSource;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private PharmacyDataSetTableAdapters.OrdersViewTableAdapter ordersViewTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PharmacyDataSetTableAdapters.MedicinesOrdersViewTableAdapter medicinesOrdersViewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPurchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.BindingSource medicinesOrdersViewBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem receiptOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.BindingSource currentOrdersViewBindingSource;
        private PharmacyDataSetTableAdapters.CurrentOrdersViewTableAdapter currentOrdersViewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listOfDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSuppliersToolStripMenuItem;
        private System.Windows.Forms.BindingSource receiptMedicinesOrdersViewBindingSource;
        private PharmacyDataSetTableAdapters.ReceiptMedicinesOrdersViewTableAdapter receiptMedicinesOrdersViewTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private PharmacyDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.ToolStripMenuItem pharmacistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPharmacistsToolStripMenuItem;
        private System.Windows.Forms.BindingSource pharmacistsViewBindingSource;
        private PharmacyDataSetTableAdapters.PharmacistsViewTableAdapter pharmacistsViewTableAdapter;
        private System.Windows.Forms.BindingSource profileViewBindingSource;
        private PharmacyDataSetTableAdapters.ProfileViewTableAdapter profileViewTableAdapter;
        private System.Windows.Forms.TabPage pharmacistTabPage;
        private System.Windows.Forms.DataGridView pharmacistsViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.TabPage suppliersTabPage;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.TabPage historyOrdersTabPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ordersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.TabPage currentOrderTabPage;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView currentOrdersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.TabPage recepitOrderTabPage;
        private System.Windows.Forms.DataGridView receiptMedicinesOrdersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TabPage purchaseDetailsPage;
        private System.Windows.Forms.DataGridView medicinesOrdersViewDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage departmentsPage;
        private System.Windows.Forms.DataGridView departmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordynatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView completeOrdersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Button archivesButton;
        private System.Windows.Forms.DataGridView medicinesViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl tabControl;
    }
}