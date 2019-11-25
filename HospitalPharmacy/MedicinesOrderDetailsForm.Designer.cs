namespace HospitalPharmacy
{
    partial class MedicinesOrderDetailsForm
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
            this.medicinesOrderDetailsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrderDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicinesOrderDetailsGridView
            // 
            this.medicinesOrderDetailsGridView.AllowUserToAddRows = false;
            this.medicinesOrderDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesOrderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesOrderDetailsGridView.Location = new System.Drawing.Point(12, 12);
            this.medicinesOrderDetailsGridView.Name = "medicinesOrderDetailsGridView";
            this.medicinesOrderDetailsGridView.Size = new System.Drawing.Size(986, 393);
            this.medicinesOrderDetailsGridView.TabIndex = 0;
            this.medicinesOrderDetailsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MedicinesOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 426);
            this.Controls.Add(this.medicinesOrderDetailsGridView);
            this.Name = "MedicinesOrderDetailsForm";
            this.Text = "Medicines Order Details";
            this.Load += new System.EventHandler(this.MedicinesOrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesOrderDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView medicinesOrderDetailsGridView;
    }
}