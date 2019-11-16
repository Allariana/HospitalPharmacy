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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.generateButton = new System.Windows.Forms.Button();
            this.medicinesGridView = new System.Windows.Forms.DataGridView();
            this.generateOrderTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateOrderViewGrid = new System.Windows.Forms.DataGridView();
            this.medicinesOrdersPage = new System.Windows.Forms.TabPage();
            this.changeOrderStatusButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineOrderIDComboBox = new System.Windows.Forms.ComboBox();
            this.medicinesOrdersGridView = new System.Windows.Forms.DataGridView();
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.departmentsGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentsAndOrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseAndShoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGridView)).BeginInit();
            this.generateOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).BeginInit();
            this.medicinesOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).BeginInit();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.orderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.generateOrderTabPage);
            this.tabControl.Controls.Add(this.medicinesOrdersPage);
            this.tabControl.Controls.Add(this.departmentsPage);
            this.tabControl.Controls.Add(this.orderTabPage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(15, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1083, 558);
            this.tabControl.TabIndex = 5;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.generateButton);
            this.stockPage.Controls.Add(this.medicinesGridView);
            this.stockPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(1075, 532);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            this.stockPage.Click += new System.EventHandler(this.stockPage_Click);
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
            // medicinesGridView
            // 
            this.medicinesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesGridView.Location = new System.Drawing.Point(17, 12);
            this.medicinesGridView.Name = "medicinesGridView";
            this.medicinesGridView.Size = new System.Drawing.Size(1012, 433);
            this.medicinesGridView.TabIndex = 0;
            this.medicinesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // generateOrderTabPage
            // 
            this.generateOrderTabPage.Controls.Add(this.label3);
            this.generateOrderTabPage.Controls.Add(this.confirmButton);
            this.generateOrderTabPage.Controls.Add(this.priceLabel);
            this.generateOrderTabPage.Controls.Add(this.label4);
            this.generateOrderTabPage.Controls.Add(this.generateOrderViewGrid);
            this.generateOrderTabPage.Location = new System.Drawing.Point(4, 22);
            this.generateOrderTabPage.Name = "generateOrderTabPage";
            this.generateOrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generateOrderTabPage.Size = new System.Drawing.Size(1075, 532);
            this.generateOrderTabPage.TabIndex = 4;
            this.generateOrderTabPage.Text = "Generate Order";
            this.generateOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(154, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "EUR";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmButton.Location = new System.Drawing.Point(397, 474);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(114, 32);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(109, 474);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 17);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price:";
            // 
            // generateOrderViewGrid
            // 
            this.generateOrderViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generateOrderViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generateOrderViewGrid.Location = new System.Drawing.Point(16, 15);
            this.generateOrderViewGrid.Name = "generateOrderViewGrid";
            this.generateOrderViewGrid.Size = new System.Drawing.Size(942, 437);
            this.generateOrderViewGrid.TabIndex = 1;
            this.generateOrderViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.generateOrderViewGrid_CellContentClick);
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
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Order Id:";
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
            // medicinesOrdersGridView
            // 
            this.medicinesOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrdersGridView.Location = new System.Drawing.Point(23, 20);
            this.medicinesOrdersGridView.Name = "medicinesOrdersGridView";
            this.medicinesOrdersGridView.Size = new System.Drawing.Size(564, 492);
            this.medicinesOrdersGridView.TabIndex = 0;
            this.medicinesOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.departmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsGridView.Location = new System.Drawing.Point(17, 19);
            this.departmentsGridView.Name = "departmentsGridView";
            this.departmentsGridView.Size = new System.Drawing.Size(457, 326);
            this.departmentsGridView.TabIndex = 0;
            this.departmentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsGridView_CellContentClick);
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
            // orderTabPage
            // 
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
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(17, 15);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(651, 492);
            this.orderGridView.TabIndex = 1;
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
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGridView)).EndInit();
            this.generateOrderTabPage.ResumeLayout(false);
            this.generateOrderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).EndInit();
            this.medicinesOrdersPage.ResumeLayout(false);
            this.medicinesOrdersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).EndInit();
            this.departmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.orderTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage departmentsPage;
        private System.Windows.Forms.DataGridView departmentsGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentsAndOrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseAndShoppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inStockToolStripMenuItem;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.DataGridView medicinesGridView;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabPage medicinesOrdersPage;
        private System.Windows.Forms.DataGridView medicinesOrdersGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox medicineOrderIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeOrderStatusButton;
        private System.Windows.Forms.TabPage generateOrderTabPage;
        private System.Windows.Forms.DataGridView generateOrderViewGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage orderTabPage;
        private System.Windows.Forms.DataGridView orderGridView;
    }
}