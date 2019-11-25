namespace HospitalPharmacy
{
    partial class MakeOrderForm
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
            this.pharmacyDataSet = new HospitalPharmacy.PharmacyDataSet();
            this.generateOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generateOrderViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter();
            this.tableAdapterManager = new HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesTableAdapter();
            this.basketGridView = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.basketLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.medicinesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.MedicinesViewTableAdapter();
            this.medicinesViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // basketGridView
            // 
            this.basketGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.Amount});
            this.basketGridView.Location = new System.Drawing.Point(793, 54);
            this.basketGridView.Name = "basketGridView";
            this.basketGridView.Size = new System.Drawing.Size(240, 298);
            this.basketGridView.TabIndex = 9;
            this.basketGridView.AllowUserToAddRowsChanged += new System.EventHandler(this.SaveButton_Click);
            this.basketGridView.AllowUserToDeleteRowsChanged += new System.EventHandler(this.SaveButton_Click);
            this.basketGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BasketGridView_CellValueChanged);
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "MedicineID";
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(821, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Location = new System.Drawing.Point(885, 21);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(40, 13);
            this.basketLabel.TabIndex = 11;
            this.basketLabel.Text = "Basket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Medicines Selection";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(933, 371);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 13;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // medicinesViewBindingSource
            // 
            this.medicinesViewBindingSource.DataMember = "MedicinesView";
            this.medicinesViewBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicinesViewTableAdapter
            // 
            this.medicinesViewTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesViewDataGridView
            // 
            this.medicinesViewDataGridView.AutoGenerateColumns = false;
            this.medicinesViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.medicinesViewDataGridView.Location = new System.Drawing.Point(12, 54);
            this.medicinesViewDataGridView.Name = "medicinesViewDataGridView";
            this.medicinesViewDataGridView.Size = new System.Drawing.Size(759, 373);
            this.medicinesViewDataGridView.TabIndex = 13;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnitsInStock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RequiredQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "RequiredQuantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn9.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn10.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.medicinesViewDataGridView);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.basketGridView);
            this.Name = "MakeOrderForm";
            this.Text = "MakeOrderForm";
            this.Load += new System.EventHandler(this.MakeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource generateOrderViewBindingSource;
        private PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter generateOrderViewTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private PharmacyDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.DataGridView basketGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource medicinesViewBindingSource;
        private PharmacyDataSetTableAdapters.MedicinesViewTableAdapter medicinesViewTableAdapter;
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
    }
}