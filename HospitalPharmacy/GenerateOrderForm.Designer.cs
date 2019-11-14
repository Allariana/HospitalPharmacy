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
            this.generateOrderViewGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // generateOrderViewGrid
            // 
            this.generateOrderViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generateOrderViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generateOrderViewGrid.Location = new System.Drawing.Point(12, 23);
            this.generateOrderViewGrid.Name = "generateOrderViewGrid";
            this.generateOrderViewGrid.Size = new System.Drawing.Size(776, 301);
            this.generateOrderViewGrid.TabIndex = 0;
            this.generateOrderViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(80, 337);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(30, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "price";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(702, 346);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(86, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "EUR";
            // 
            // GenerateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateOrderViewGrid);
            this.Name = "GenerateOrderForm";
            this.Text = "Generate Order";
            ((System.ComponentModel.ISupportInitialize)(this.generateOrderViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView generateOrderViewGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
    }
}