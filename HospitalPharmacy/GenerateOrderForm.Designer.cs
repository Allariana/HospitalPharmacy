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
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.generateOrderViewTableAdapter = new HospitalPharmacy.PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosemgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeSubstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateOrderViewGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(98, 337);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 17);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "price";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "EUR";
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
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
            // generateOrderViewGrid
            // 
            this.generateOrderViewGrid.AutoGenerateColumns = false;
            this.generateOrderViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generateOrderViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generateOrderViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeNameDataGridViewTextBoxColumn,
            this.activeSubstanceDataGridViewTextBoxColumn,
            this.dosemgDataGridViewTextBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceEURDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.generateOrderViewGrid.DataSource = this.generateOrderViewBindingSource;
            this.generateOrderViewGrid.Location = new System.Drawing.Point(12, 23);
            this.generateOrderViewGrid.Name = "generateOrderViewGrid";
            this.generateOrderViewGrid.Size = new System.Drawing.Size(871, 298);
            this.generateOrderViewGrid.TabIndex = 0;
            this.generateOrderViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GenerateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 394);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateOrderViewGrid);
            this.Name = "GenerateOrderForm";
            this.Text = "Generate Order";
            this.Load += new System.EventHandler(this.GenerateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource generateOrderViewBindingSource;
        private PharmacyDataSetTableAdapters.GenerateOrderViewTableAdapter generateOrderViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosemgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeSubstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView generateOrderViewGrid;
    }
}