namespace HospitalPharmacy
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
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
            this.pharmacistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPharmacistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedInformationAboutPharmacistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.departmentsGridView = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordynatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new HospitalPharmacy.PharmacyDataSet();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MedicinesOrders = new System.Windows.Forms.TabPage();
            this.medicinesOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesOrdersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chooseActionComboBox = new System.Windows.Forms.ComboBox();
            this.changeOrderStatusButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineOrderIDComboBox = new System.Windows.Forms.ComboBox();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.medicinesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.purchaseDetailsPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.medicinesOrdersViewDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recepitOrderTabPage = new System.Windows.Forms.TabPage();
            this.receiptMedicinesOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptMedicinesOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentOrderTabPage = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.currentOrdersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesViewDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.orderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            this.MedicinesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource1)).BeginInit();
            this.stockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.purchaseDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).BeginInit();
            this.recepitOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewBindingSource)).BeginInit();
            this.currentOrderTabPage.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(741, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed in as:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserLabel.Location = new System.Drawing.Point(831, 8);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(70, 19);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Username";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutButton.Location = new System.Drawing.Point(924, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 27);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsAndOrToolStripMenuItem,
            this.warehouseAndShoppingToolStripMenuItem,
            this.pharmacistsToolStripMenuItem,
            this.suppliersToolStripMenuItem});
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
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            // 
            // completeOrderToolStripMenuItem
            // 
            this.completeOrderToolStripMenuItem.Name = "completeOrderToolStripMenuItem";
            this.completeOrderToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.completeOrderToolStripMenuItem.Text = "Complete Order";
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
            // pharmacistsToolStripMenuItem
            // 
            this.pharmacistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfPharmacistsToolStripMenuItem,
            this.detailedInformationAboutPharmacistsToolStripMenuItem});
            this.pharmacistsToolStripMenuItem.Name = "pharmacistsToolStripMenuItem";
            this.pharmacistsToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.pharmacistsToolStripMenuItem.Text = "Pharmacists";
            // 
            // listOfPharmacistsToolStripMenuItem
            // 
            this.listOfPharmacistsToolStripMenuItem.Name = "listOfPharmacistsToolStripMenuItem";
            this.listOfPharmacistsToolStripMenuItem.Size = new System.Drawing.Size(347, 24);
            this.listOfPharmacistsToolStripMenuItem.Text = "List of Pharmacists";
            // 
            // detailedInformationAboutPharmacistsToolStripMenuItem
            // 
            this.detailedInformationAboutPharmacistsToolStripMenuItem.Name = "detailedInformationAboutPharmacistsToolStripMenuItem";
            this.detailedInformationAboutPharmacistsToolStripMenuItem.Size = new System.Drawing.Size(347, 24);
            this.detailedInformationAboutPharmacistsToolStripMenuItem.Text = "Detailed information about pharmacists";
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
            // departmentsPage
            // 
            this.departmentsPage.Controls.Add(this.departmentsGridView);
            this.departmentsPage.Location = new System.Drawing.Point(4, 26);
            this.departmentsPage.Name = "departmentsPage";
            this.departmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsPage.Size = new System.Drawing.Size(1075, 544);
            this.departmentsPage.TabIndex = 1;
            this.departmentsPage.Text = "Departments";
            this.departmentsPage.UseVisualStyleBackColor = true;
            this.departmentsPage.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.departmentsGridView.Location = new System.Drawing.Point(17, 19);
            this.departmentsGridView.Name = "departmentsGridView";
            this.departmentsGridView.ReadOnly = true;
            this.departmentsGridView.Size = new System.Drawing.Size(504, 326);
            this.departmentsGridView.TabIndex = 0;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordynatorNameDataGridViewTextBoxColumn
            // 
            this.ordynatorNameDataGridViewTextBoxColumn.DataPropertyName = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.HeaderText = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.Name = "ordynatorNameDataGridViewTextBoxColumn";
            this.ordynatorNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // orderTabPage
            // 
            this.orderTabPage.Controls.Add(this.actionComboBox);
            this.orderTabPage.Controls.Add(this.completeButton);
            this.orderTabPage.Controls.Add(this.button1);
            this.orderTabPage.Controls.Add(this.ordersComboBox);
            this.orderTabPage.Controls.Add(this.label5);
            this.orderTabPage.Controls.Add(this.orderGridView);
            this.orderTabPage.Location = new System.Drawing.Point(4, 26);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(1075, 544);
            this.orderTabPage.TabIndex = 5;
            this.orderTabPage.Text = "Orders";
            this.orderTabPage.UseVisualStyleBackColor = true;
            this.orderTabPage.Click += new System.EventHandler(this.orderTabPage_Click);
            // 
            // actionComboBox
            // 
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Check Order Details",
            "Complete Order"});
            this.actionComboBox.Location = new System.Drawing.Point(33, 27);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(165, 25);
            this.actionComboBox.TabIndex = 8;
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(809, 277);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(132, 23);
            this.completeButton.TabIndex = 7;
            this.completeButton.Text = "Complete order";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check Order Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(866, 167);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(121, 25);
            this.ordersComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Order Id:";
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.orderstatusDataGridViewTextBoxColumn1,
            this.realizationDateDataGridViewTextBoxColumn1,
            this.whoIssuedDataGridViewTextBoxColumn});
            this.orderGridView.DataSource = this.ordersViewBindingSource;
            this.orderGridView.Location = new System.Drawing.Point(17, 81);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.Size = new System.Drawing.Size(651, 426);
            this.orderGridView.TabIndex = 1;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellContentClick);
            this.orderGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellDoubleClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentNameDataGridViewTextBoxColumn1
            // 
            this.departmentNameDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn1.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn1.Name = "departmentNameDataGridViewTextBoxColumn1";
            this.departmentNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            this.orderDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderstatusDataGridViewTextBoxColumn1
            // 
            this.orderstatusDataGridViewTextBoxColumn1.DataPropertyName = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn1.HeaderText = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn1.Name = "orderstatusDataGridViewTextBoxColumn1";
            this.orderstatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // realizationDateDataGridViewTextBoxColumn1
            // 
            this.realizationDateDataGridViewTextBoxColumn1.DataPropertyName = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn1.HeaderText = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn1.Name = "realizationDateDataGridViewTextBoxColumn1";
            this.realizationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // whoIssuedDataGridViewTextBoxColumn
            // 
            this.whoIssuedDataGridViewTextBoxColumn.DataPropertyName = "WhoIssued";
            this.whoIssuedDataGridViewTextBoxColumn.HeaderText = "WhoIssued";
            this.whoIssuedDataGridViewTextBoxColumn.Name = "whoIssuedDataGridViewTextBoxColumn";
            this.whoIssuedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataMember = "OrdersView";
            this.ordersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // MedicinesOrders
            // 
            this.MedicinesOrders.Controls.Add(this.medicinesOrdersViewDataGridView);
            this.MedicinesOrders.Controls.Add(this.chooseActionComboBox);
            this.MedicinesOrders.Controls.Add(this.changeOrderStatusButton);
            this.MedicinesOrders.Controls.Add(this.checkButton);
            this.MedicinesOrders.Controls.Add(this.label2);
            this.MedicinesOrders.Controls.Add(this.medicineOrderIDComboBox);
            this.MedicinesOrders.Location = new System.Drawing.Point(4, 26);
            this.MedicinesOrders.Name = "MedicinesOrders";
            this.MedicinesOrders.Padding = new System.Windows.Forms.Padding(3);
            this.MedicinesOrders.Size = new System.Drawing.Size(1075, 544);
            this.MedicinesOrders.TabIndex = 3;
            this.MedicinesOrders.Text = "Purchase Orders";
            this.MedicinesOrders.UseVisualStyleBackColor = true;
            this.MedicinesOrders.Click += new System.EventHandler(this.medicinesOrdersPage_Click);
            // 
            // medicinesOrdersViewDataGridView
            // 
            this.medicinesOrdersViewDataGridView.AllowUserToAddRows = false;
            this.medicinesOrdersViewDataGridView.AllowUserToDeleteRows = false;
            this.medicinesOrdersViewDataGridView.AutoGenerateColumns = false;
            this.medicinesOrdersViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrdersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrdersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn13});
            this.medicinesOrdersViewDataGridView.DataSource = this.medicinesOrdersViewBindingSource1;
            this.medicinesOrdersViewDataGridView.Location = new System.Drawing.Point(24, 24);
            this.medicinesOrdersViewDataGridView.Name = "medicinesOrdersViewDataGridView";
            this.medicinesOrdersViewDataGridView.ReadOnly = true;
            this.medicinesOrdersViewDataGridView.Size = new System.Drawing.Size(654, 220);
            this.medicinesOrdersViewDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn11.HeaderText = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn14.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "WhoOrdered";
            this.dataGridViewTextBoxColumn16.HeaderText = "WhoOrdered";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn13.HeaderText = "Price";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // medicinesOrdersViewBindingSource1
            // 
            this.medicinesOrdersViewBindingSource1.DataMember = "MedicinesOrdersView";
            this.medicinesOrdersViewBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // chooseActionComboBox
            // 
            this.chooseActionComboBox.FormattingEnabled = true;
            this.chooseActionComboBox.Items.AddRange(new object[] {
            "Check Order Details",
            "Receipt of Order"});
            this.chooseActionComboBox.Location = new System.Drawing.Point(778, 67);
            this.chooseActionComboBox.Name = "chooseActionComboBox";
            this.chooseActionComboBox.Size = new System.Drawing.Size(165, 25);
            this.chooseActionComboBox.TabIndex = 9;
            // 
            // changeOrderStatusButton
            // 
            this.changeOrderStatusButton.Location = new System.Drawing.Point(761, 284);
            this.changeOrderStatusButton.Name = "changeOrderStatusButton";
            this.changeOrderStatusButton.Size = new System.Drawing.Size(132, 23);
            this.changeOrderStatusButton.TabIndex = 6;
            this.changeOrderStatusButton.Text = "Receipt of the order";
            this.changeOrderStatusButton.UseVisualStyleBackColor = true;
            this.changeOrderStatusButton.Click += new System.EventHandler(this.changeOrderStatusButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(761, 221);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(132, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check Order Details";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Order Id:";
            // 
            // medicineOrderIDComboBox
            // 
            this.medicineOrderIDComboBox.FormattingEnabled = true;
            this.medicineOrderIDComboBox.Location = new System.Drawing.Point(835, 150);
            this.medicineOrderIDComboBox.Name = "medicineOrderIDComboBox";
            this.medicineOrderIDComboBox.Size = new System.Drawing.Size(121, 25);
            this.medicineOrderIDComboBox.TabIndex = 2;
            this.medicineOrderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.medicineOrderIDComboBox_SelectedIndexChanged);
            // 
            // stockPage
            // 
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
            // medicinesViewBindingSource
            // 
            this.medicinesViewBindingSource.DataMember = "MedicinesView";
            this.medicinesViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeOrderButton.Location = new System.Drawing.Point(368, 461);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(140, 46);
            this.makeOrderButton.TabIndex = 8;
            this.makeOrderButton.Text = "Make order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(620, 461);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(140, 46);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate order";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.MedicinesOrders);
            this.tabControl.Controls.Add(this.orderTabPage);
            this.tabControl.Controls.Add(this.departmentsPage);
            this.tabControl.Controls.Add(this.purchaseDetailsPage);
            this.tabControl.Controls.Add(this.recepitOrderTabPage);
            this.tabControl.Controls.Add(this.currentOrderTabPage);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(15, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1083, 574);
            this.tabControl.TabIndex = 5;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
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
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn17.HeaderText = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn19.HeaderText = "Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn20.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn21.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "WhoOrdered";
            this.dataGridViewTextBoxColumn22.HeaderText = "WhoOrdered";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // medicinesOrdersViewBindingSource
            // 
            this.medicinesOrdersViewBindingSource.DataMember = "MedicinesOrdersView";
            this.medicinesOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
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
            this.receiptMedicinesOrdersViewDataGridView.Location = new System.Drawing.Point(23, 19);
            this.receiptMedicinesOrdersViewDataGridView.Name = "receiptMedicinesOrdersViewDataGridView";
            this.receiptMedicinesOrdersViewDataGridView.ReadOnly = true;
            this.receiptMedicinesOrdersViewDataGridView.Size = new System.Drawing.Size(662, 288);
            this.receiptMedicinesOrdersViewDataGridView.TabIndex = 0;
            this.receiptMedicinesOrdersViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptMedicinesOrdersViewDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn23.HeaderText = "MedicinesOrderID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn24.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn25.HeaderText = "Price";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn26.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn27.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "WhoOrdered";
            this.dataGridViewTextBoxColumn28.HeaderText = "WhoOrdered";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // receiptMedicinesOrdersViewBindingSource
            // 
            this.receiptMedicinesOrdersViewBindingSource.DataMember = "ReceiptMedicinesOrdersView";
            this.receiptMedicinesOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
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
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn29.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn30.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn31.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Order_status";
            this.dataGridViewTextBoxColumn32.HeaderText = "Order_status";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "RealizationDate";
            this.dataGridViewTextBoxColumn33.HeaderText = "RealizationDate";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "WhoIssued";
            this.dataGridViewTextBoxColumn34.HeaderText = "WhoIssued";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // currentOrdersViewBindingSource
            // 
            this.currentOrdersViewBindingSource.DataMember = "CurrentOrdersView";
            this.currentOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // medicinesViewDataGridView
            // 
            this.medicinesViewDataGridView.AllowUserToAddRows = false;
            this.medicinesViewDataGridView.AllowUserToDeleteRows = false;
            this.medicinesViewDataGridView.AutoGenerateColumns = false;
            this.medicinesViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.medicinesViewDataGridView.Location = new System.Drawing.Point(13, 23);
            this.medicinesViewDataGridView.Name = "medicinesViewDataGridView";
            this.medicinesViewDataGridView.ReadOnly = true;
            this.medicinesViewDataGridView.Size = new System.Drawing.Size(1041, 383);
            this.medicinesViewDataGridView.TabIndex = 8;
            this.medicinesViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicinesViewDataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 548);
            this.panel1.TabIndex = 3;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 616);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPageForm";
            this.Text = "PharmKing";
            this.Load += new System.EventHandler(this.MainPagecs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.departmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.orderTabPage.ResumeLayout(false);
            this.orderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            this.MedicinesOrders.ResumeLayout(false);
            this.MedicinesOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource1)).EndInit();
            this.stockPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.purchaseDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).EndInit();
            this.recepitOrderTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMedicinesOrdersViewBindingSource)).EndInit();
            this.currentOrderTabPage.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLabel;
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
        private System.Windows.Forms.TabPage departmentsPage;
        private System.Windows.Forms.DataGridView departmentsGridView;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.TabPage MedicinesOrders;
        private System.Windows.Forms.Button changeOrderStatusButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox medicineOrderIDComboBox;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl tabControl;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.ComboBox chooseActionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PharmacyDataSetTableAdapters.MedicinesOrdersViewTableAdapter medicinesOrdersViewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPurchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordynatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem pharmacistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPharmacistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedInformationAboutPharmacistsToolStripMenuItem;
        private System.Windows.Forms.DataGridView medicinesOrdersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource medicinesOrdersViewBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem receiptOfOrdersToolStripMenuItem;
        private System.Windows.Forms.TabPage purchaseDetailsPage;
        private System.Windows.Forms.DataGridView medicinesOrdersViewDataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage recepitOrderTabPage;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.TabPage currentOrderTabPage;
        private System.Windows.Forms.BindingSource currentOrdersViewBindingSource;
        private PharmacyDataSetTableAdapters.CurrentOrdersViewTableAdapter currentOrdersViewTableAdapter;
        private System.Windows.Forms.DataGridView currentOrdersViewDataGridView;
        private System.Windows.Forms.ToolStripMenuItem listOfDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSuppliersToolStripMenuItem;
        private System.Windows.Forms.BindingSource receiptMedicinesOrdersViewBindingSource;
        private PharmacyDataSetTableAdapters.ReceiptMedicinesOrdersViewTableAdapter receiptMedicinesOrdersViewTableAdapter;
        private System.Windows.Forms.DataGridView receiptMedicinesOrdersViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
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
        private System.Windows.Forms.Panel panel1;
    }
}