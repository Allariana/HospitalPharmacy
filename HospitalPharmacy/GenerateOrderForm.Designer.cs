namespace HospitalPharmacy
{
    partial class GenerateOrderForm
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
            this.generateOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new HospitalPharmacy.PharmacyDataSet();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.generateOrderViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter();
            this.tableAdapterManager = new HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.generateOrderViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generateOrderViewBindingSource
            // 
            this.generateOrderViewBindingSource.DataMember = "GenerateOrderView";
            this.generateOrderViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmButton.Location = new System.Drawing.Point(386, 337);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(114, 32);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(768, 346);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to Main Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateOrderViewTableAdapter
            // 
            this.generateOrderViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.MedicineOrderDetailsTableAdapter = null;
            this.tableAdapterManager.MedicinesOrdersTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PackageOfMedicineTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDetailsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // generateOrderViewDataGridView
            // 
            this.generateOrderViewDataGridView.AllowUserToAddRows = false;
            this.generateOrderViewDataGridView.AllowUserToDeleteRows = false;
            this.generateOrderViewDataGridView.AutoGenerateColumns = false;
            this.generateOrderViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generateOrderViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generateOrderViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.generateOrderViewDataGridView.DataSource = this.generateOrderViewBindingSource;
            this.generateOrderViewDataGridView.Location = new System.Drawing.Point(12, 12);
            this.generateOrderViewDataGridView.Name = "generateOrderViewDataGridView";
            this.generateOrderViewDataGridView.ReadOnly = true;
            this.generateOrderViewDataGridView.Size = new System.Drawing.Size(871, 307);
            this.generateOrderViewDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MedicineID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MedicineID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TradeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TradeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActiveSubstance";
            this.dataGridViewTextBoxColumn3.HeaderText = "ActiveSubstance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dose(mg)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dose(mg)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn6.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // GenerateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 394);
            this.Controls.Add(this.generateOrderViewDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "GenerateOrderForm";
            this.Text = "Generate Order";
            this.Load += new System.EventHandler(this.GenerateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource generateOrderViewBindingSource;
        private PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter generateOrderViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceEURDataGridViewTextBoxColumn;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView generateOrderViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}