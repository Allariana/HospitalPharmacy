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
            this.departmentsPage = new System.Windows.Forms.TabPage();
            this.departmentsGridView = new System.Windows.Forms.DataGridView();
            this.medicinesOrdersPage = new System.Windows.Forms.TabPage();
            this.medicinesOrdersGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmentsAndOrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseAndShoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGridView)).BeginInit();
            this.departmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
            this.medicinesOrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signed in as:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(1107, 14);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Username";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(1168, 9);
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
            this.tabControl.Controls.Add(this.medicinesOrdersPage);
            this.tabControl.Controls.Add(this.departmentsPage);
            this.tabControl.Location = new System.Drawing.Point(15, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1228, 558);
            this.tabControl.TabIndex = 5;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.generateButton);
            this.stockPage.Controls.Add(this.medicinesGridView);
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(1220, 532);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(17, 491);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(88, 23);
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
            this.medicinesGridView.Size = new System.Drawing.Size(1012, 473);
            this.medicinesGridView.TabIndex = 0;
            this.medicinesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departmentsPage
            // 
            this.departmentsPage.Controls.Add(this.departmentsGridView);
            this.departmentsPage.Location = new System.Drawing.Point(4, 22);
            this.departmentsPage.Name = "departmentsPage";
            this.departmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentsPage.Size = new System.Drawing.Size(1220, 532);
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
            // medicinesOrdersPage
            // 
            this.medicinesOrdersPage.Controls.Add(this.medicinesOrdersGridView);
            this.medicinesOrdersPage.Location = new System.Drawing.Point(4, 22);
            this.medicinesOrdersPage.Name = "medicinesOrdersPage";
            this.medicinesOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.medicinesOrdersPage.Size = new System.Drawing.Size(1220, 532);
            this.medicinesOrdersPage.TabIndex = 3;
            this.medicinesOrdersPage.Text = "Medicines Orders";
            this.medicinesOrdersPage.UseVisualStyleBackColor = true;
            // 
            // medicinesOrdersGridView
            // 
            this.medicinesOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrdersGridView.Location = new System.Drawing.Point(23, 20);
            this.medicinesOrdersGridView.Name = "medicinesOrdersGridView";
            this.medicinesOrdersGridView.Size = new System.Drawing.Size(564, 302);
            this.medicinesOrdersGridView.TabIndex = 0;
            this.medicinesOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsAndOrToolStripMenuItem,
            this.warehouseAndShoppingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 24);
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
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 608);
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
            this.departmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
            this.medicinesOrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrdersGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
    }
}