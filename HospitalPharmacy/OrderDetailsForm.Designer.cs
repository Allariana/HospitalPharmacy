namespace HospitalPharmacy
{
    partial class OrderDetailsForm
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
            this.orderDetailsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsGridView
            // 
            this.orderDetailsGridView.AllowUserToAddRows = false;
            this.orderDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsGridView.Location = new System.Drawing.Point(13, 24);
            this.orderDetailsGridView.Name = "orderDetailsGridView";
            this.orderDetailsGridView.RowTemplate.ReadOnly = true;
            this.orderDetailsGridView.Size = new System.Drawing.Size(766, 414);
            this.orderDetailsGridView.TabIndex = 0;
            this.orderDetailsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDetailsGridView_CellContentClick);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderDetailsGridView);
            this.Name = "OrderDetailsForm";
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDetailsGridView;
    }
}