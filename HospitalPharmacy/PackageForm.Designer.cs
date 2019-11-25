namespace HospitalPharmacy
{
    partial class PackageForm
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
            this.packageOfMedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageOfMedicineTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.PackageOfMedicineTableAdapter();
            this.tableAdapterManager = new HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.packageOfMedicineDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageOfMedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageOfMedicineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageOfMedicineBindingSource
            // 
            this.packageOfMedicineBindingSource.DataMember = "PackageOfMedicine";
            this.packageOfMedicineBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // packageOfMedicineTableAdapter
            // 
            this.packageOfMedicineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.MedicineOrderDetailsTableAdapter = null;
            this.tableAdapterManager.MedicinesOrdersTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PackageOfMedicineTableAdapter = this.packageOfMedicineTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalPharmacy.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDetailsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // packageOfMedicineDataGridView
            // 
            this.packageOfMedicineDataGridView.AllowUserToAddRows = false;
            this.packageOfMedicineDataGridView.AllowUserToDeleteRows = false;
            this.packageOfMedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageOfMedicineDataGridView.Location = new System.Drawing.Point(12, 12);
            this.packageOfMedicineDataGridView.Name = "packageOfMedicineDataGridView";
            this.packageOfMedicineDataGridView.ReadOnly = true;
            this.packageOfMedicineDataGridView.Size = new System.Drawing.Size(414, 426);
            this.packageOfMedicineDataGridView.TabIndex = 1;
            this.packageOfMedicineDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packageOfMedicineDataGridView_CellContentClick);
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.packageOfMedicineDataGridView);
            this.Name = "PackageForm";
            this.Text = "PackageForm";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageOfMedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageOfMedicineDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource packageOfMedicineBindingSource;
        private PharmacyDataSetTableAdapters.PackageOfMedicineTableAdapter packageOfMedicineTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView packageOfMedicineDataGridView;
    }
}