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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.medicinesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new HospitalPharmacy.PharmacyDataSet();
            this.generateOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentsAndOrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseAndShoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesTableAdapter();
            this.medicinesViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesViewTableAdapter();
            this.generateOrderViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter();
            this.departmentsTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.DepartmentsTableAdapter();
            this.medicinesOrdersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesOrdersViewTableAdapter();
            this.ordersViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.OrdersViewTableAdapter();
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.departmentsGridView = new System.Windows.Forms.DataGridView();
            this.ordynatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.whoIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.medicinesOrdersPage = new System.Windows.Forms.TabPage();
            this.medicinesOrdersGridView = new System.Windows.Forms.DataGridView();
            this.whoOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineOrderIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.changeOrderStatusButton = new System.Windows.Forms.Button();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.medicinesGridView = new System.Windows.Forms.DataGridView();
            this.requiredQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosemgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeSubstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
            this.orderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.medicinesOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).BeginInit();
            this.stockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed in as:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(851, 17);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Username";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(931, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // medicinesViewBindingSource
            // 
            this.medicinesViewBindingSource.DataMember = "MedicinesView";
            this.medicinesViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generateOrderViewBindingSource
            // 
            this.generateOrderViewBindingSource.DataMember = "GenerateOrderView";
            this.generateOrderViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesOrdersViewBindingSource
            // 
            this.medicinesOrdersViewBindingSource.DataMember = "MedicinesOrdersView";
            this.medicinesOrdersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataMember = "OrdersView";
            this.ordersViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsAndOrToolStripMenuItem,
            this.warehouseAndShoppingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departmentsAndOrToolStripMenuItem
            // 
            this.departmentsAndOrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfDepartmentsToolStripMenuItem});
            this.departmentsAndOrToolStripMenuItem.Name = "departmentsAndOrToolStripMenuItem";
            this.departmentsAndOrToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.departmentsAndOrToolStripMenuItem.Text = "Departments and orders";
            // 
            // listOfDepartmentsToolStripMenuItem
            // 
            this.listOfDepartmentsToolStripMenuItem.Name = "listOfDepartmentsToolStripMenuItem";
            this.listOfDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listOfDepartmentsToolStripMenuItem.Text = "List of Departments";
            this.listOfDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.listOfDepartmentsToolStripMenuItem_Click_1);
            // 
            // warehouseAndShoppingToolStripMenuItem
            // 
            this.warehouseAndShoppingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inStockToolStripMenuItem});
            this.warehouseAndShoppingToolStripMenuItem.Name = "warehouseAndShoppingToolStripMenuItem";
            this.warehouseAndShoppingToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.warehouseAndShoppingToolStripMenuItem.Text = "Warehouse and shopping";
            // 
            // inStockToolStripMenuItem
            // 
            this.inStockToolStripMenuItem.Name = "inStockToolStripMenuItem";
            this.inStockToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inStockToolStripMenuItem.Text = "In stock";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1023, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
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
            // medicinesOrdersViewTableAdapter
            // 
            this.medicinesOrdersViewTableAdapter.ClearBeforeFill = true;
            // 
            // ordersViewTableAdapter
            // 
            this.ordersViewTableAdapter.ClearBeforeFill = true;
            // 
            // departmentsPage
            // 
            this.departmentsPage.Controls.Add(this.departmentsGridView);
            this.departmentsPage.Location = new System.Drawing.Point(4, 22);
            this.departmentsPage.Name = "departmentsPage";
            this.departmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsPage.Size = new System.Drawing.Size(1075, 532);
            this.departmentsPage.TabIndex = 1;
            this.departmentsPage.Text = "Departments";
            this.departmentsPage.UseVisualStyleBackColor = true;
            this.departmentsPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // departmentsGridView
            // 
            this.departmentsGridView.AutoGenerateColumns = false;
            this.departmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.ordynatorNameDataGridViewTextBoxColumn});
            this.departmentsGridView.DataSource = this.departmentsBindingSource;
            this.departmentsGridView.Location = new System.Drawing.Point(17, 19);
            this.departmentsGridView.Name = "departmentsGridView";
            this.departmentsGridView.Size = new System.Drawing.Size(504, 326);
            this.departmentsGridView.TabIndex = 0;
            this.departmentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsGridView_CellContentClick);
            // 
            // ordynatorNameDataGridViewTextBoxColumn
            // 
            this.ordynatorNameDataGridViewTextBoxColumn.DataPropertyName = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.HeaderText = "OrdynatorName";
            this.ordynatorNameDataGridViewTextBoxColumn.Name = "ordynatorNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // orderTabPage
            // 
            this.orderTabPage.Controls.Add(this.completeButton);
            this.orderTabPage.Controls.Add(this.button1);
            this.orderTabPage.Controls.Add(this.ordersComboBox);
            this.orderTabPage.Controls.Add(this.label5);
            this.orderTabPage.Controls.Add(this.orderGridView);
            this.orderTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderTabPage.Size = new System.Drawing.Size(1075, 532);
            this.orderTabPage.TabIndex = 5;
            this.orderTabPage.Text = "Orders";
            this.orderTabPage.UseVisualStyleBackColor = true;
            // 
            // orderGridView
            // 
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
            this.orderGridView.Location = new System.Drawing.Point(17, 15);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(651, 492);
            this.orderGridView.TabIndex = 1;
            // 
            // whoIssuedDataGridViewTextBoxColumn
            // 
            this.whoIssuedDataGridViewTextBoxColumn.DataPropertyName = "WhoIssued";
            this.whoIssuedDataGridViewTextBoxColumn.HeaderText = "WhoIssued";
            this.whoIssuedDataGridViewTextBoxColumn.Name = "whoIssuedDataGridViewTextBoxColumn";
            this.whoIssuedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realizationDateDataGridViewTextBoxColumn1
            // 
            this.realizationDateDataGridViewTextBoxColumn1.DataPropertyName = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn1.HeaderText = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn1.Name = "realizationDateDataGridViewTextBoxColumn1";
            // 
            // orderstatusDataGridViewTextBoxColumn1
            // 
            this.orderstatusDataGridViewTextBoxColumn1.DataPropertyName = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn1.HeaderText = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn1.Name = "orderstatusDataGridViewTextBoxColumn1";
            this.orderstatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            // 
            // departmentNameDataGridViewTextBoxColumn1
            // 
            this.departmentNameDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn1.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn1.Name = "departmentNameDataGridViewTextBoxColumn1";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Order Id:";
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(866, 167);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(121, 21);
            this.ordersComboBox.TabIndex = 5;
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
            // medicinesOrdersPage
            // 
            this.medicinesOrdersPage.Controls.Add(this.changeOrderStatusButton);
            this.medicinesOrdersPage.Controls.Add(this.checkButton);
            this.medicinesOrdersPage.Controls.Add(this.label2);
            this.medicinesOrdersPage.Controls.Add(this.medicineOrderIDComboBox);
            this.medicinesOrdersPage.Controls.Add(this.medicinesOrdersGridView);
            this.medicinesOrdersPage.Location = new System.Drawing.Point(4, 22);
            this.medicinesOrdersPage.Name = "medicinesOrdersPage";
            this.medicinesOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.medicinesOrdersPage.Size = new System.Drawing.Size(1075, 532);
            this.medicinesOrdersPage.TabIndex = 3;
            this.medicinesOrdersPage.Text = "Medicines Orders";
            this.medicinesOrdersPage.UseVisualStyleBackColor = true;
            // 
            // medicinesOrdersGridView
            // 
            this.medicinesOrdersGridView.AutoGenerateColumns = false;
            this.medicinesOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.orderstatusDataGridViewTextBoxColumn,
            this.realizationDateDataGridViewTextBoxColumn,
            this.whoOrderedDataGridViewTextBoxColumn});
            this.medicinesOrdersGridView.DataSource = this.medicinesOrdersViewBindingSource;
            this.medicinesOrdersGridView.Location = new System.Drawing.Point(23, 20);
            this.medicinesOrdersGridView.Name = "medicinesOrdersGridView";
            this.medicinesOrdersGridView.Size = new System.Drawing.Size(564, 492);
            this.medicinesOrdersGridView.TabIndex = 0;
            this.medicinesOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // whoOrderedDataGridViewTextBoxColumn
            // 
            this.whoOrderedDataGridViewTextBoxColumn.DataPropertyName = "WhoOrdered";
            this.whoOrderedDataGridViewTextBoxColumn.HeaderText = "WhoOrdered";
            this.whoOrderedDataGridViewTextBoxColumn.Name = "whoOrderedDataGridViewTextBoxColumn";
            this.whoOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realizationDateDataGridViewTextBoxColumn
            // 
            this.realizationDateDataGridViewTextBoxColumn.DataPropertyName = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn.HeaderText = "RealizationDate";
            this.realizationDateDataGridViewTextBoxColumn.Name = "realizationDateDataGridViewTextBoxColumn";
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "Order_status";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // medicineOrderIDComboBox
            // 
            this.medicineOrderIDComboBox.FormattingEnabled = true;
            this.medicineOrderIDComboBox.Location = new System.Drawing.Point(835, 150);
            this.medicineOrderIDComboBox.Name = "medicineOrderIDComboBox";
            this.medicineOrderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.medicineOrderIDComboBox.TabIndex = 2;
            this.medicineOrderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.medicineOrderIDComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Order Id:";
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
            // stockPage
            // 
            this.stockPage.Controls.Add(this.generateButton);
            this.stockPage.Controls.Add(this.medicinesGridView);
            this.stockPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(1075, 532);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            this.stockPage.Click += new System.EventHandler(this.stockPage_Click);
            // 
            // medicinesGridView
            // 
            this.medicinesGridView.AutoGenerateColumns = false;
            this.medicinesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeNameDataGridViewTextBoxColumn,
            this.activeSubstanceDataGridViewTextBoxColumn,
            this.dosemgDataGridViewTextBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceEURDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.requiredQuantityDataGridViewTextBoxColumn});
            this.medicinesGridView.DataSource = this.medicinesViewBindingSource;
            this.medicinesGridView.Location = new System.Drawing.Point(17, 12);
            this.medicinesGridView.Name = "medicinesGridView";
            this.medicinesGridView.Size = new System.Drawing.Size(1028, 433);
            this.medicinesGridView.TabIndex = 0;
            this.medicinesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // requiredQuantityDataGridViewTextBoxColumn
            // 
            this.requiredQuantityDataGridViewTextBoxColumn.DataPropertyName = "RequiredQuantity";
            this.requiredQuantityDataGridViewTextBoxColumn.HeaderText = "RequiredQuantity";
            this.requiredQuantityDataGridViewTextBoxColumn.Name = "requiredQuantityDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitPriceEURDataGridViewTextBoxColumn
            // 
            this.unitPriceEURDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice(EUR)";
            this.unitPriceEURDataGridViewTextBoxColumn.HeaderText = "UnitPrice(EUR)";
            this.unitPriceEURDataGridViewTextBoxColumn.Name = "unitPriceEURDataGridViewTextBoxColumn";
            // 
            // quantityPerUnitDataGridViewTextBoxColumn
            // 
            this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
            // 
            // dosemgDataGridViewTextBoxColumn
            // 
            this.dosemgDataGridViewTextBoxColumn.DataPropertyName = "Dose(mg)";
            this.dosemgDataGridViewTextBoxColumn.HeaderText = "Dose(mg)";
            this.dosemgDataGridViewTextBoxColumn.Name = "dosemgDataGridViewTextBoxColumn";
            // 
            // activeSubstanceDataGridViewTextBoxColumn
            // 
            this.activeSubstanceDataGridViewTextBoxColumn.DataPropertyName = "ActiveSubstance";
            this.activeSubstanceDataGridViewTextBoxColumn.HeaderText = "ActiveSubstance";
            this.activeSubstanceDataGridViewTextBoxColumn.Name = "activeSubstanceDataGridViewTextBoxColumn";
            // 
            // tradeNameDataGridViewTextBoxColumn
            // 
            this.tradeNameDataGridViewTextBoxColumn.DataPropertyName = "TradeName";
            this.tradeNameDataGridViewTextBoxColumn.HeaderText = "TradeName";
            this.tradeNameDataGridViewTextBoxColumn.Name = "tradeNameDataGridViewTextBoxColumn";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(437, 461);
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
            this.tabControl.Controls.Add(this.medicinesOrdersPage);
            this.tabControl.Controls.Add(this.orderTabPage);
            this.tabControl.Controls.Add(this.departmentsPage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(15, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1083, 558);
            this.tabControl.TabIndex = 5;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 608);
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
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.departmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
            this.orderTabPage.ResumeLayout(false);
            this.orderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.medicinesOrdersPage.ResumeLayout(false);
            this.medicinesOrdersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).EndInit();
            this.stockPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentsAndOrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfDepartmentsToolStripMenuItem;
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
        private PharmacyDataSetTableAdapters.MedicinesOrdersViewTableAdapter medicinesOrdersViewTableAdapter;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
        private PharmacyDataSetTableAdapters.OrdersViewTableAdapter ordersViewTableAdapter;
        private System.Windows.Forms.TabPage departmentsPage;
        private System.Windows.Forms.DataGridView departmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordynatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage medicinesOrdersPage;
        private System.Windows.Forms.Button changeOrderStatusButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox medicineOrderIDComboBox;
        private System.Windows.Forms.DataGridView medicinesOrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realizationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView medicinesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeSubstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosemgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl;
    }
}