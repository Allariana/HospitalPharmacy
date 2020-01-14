namespace HospitalPharmacy
{
    partial class PackagesToIssueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.packagesBasketDataGridView = new System.Windows.Forms.DataGridView();
            this.issueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBasketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // packagesBasketDataGridView
            // 
            this.packagesBasketDataGridView.AllowUserToAddRows = false;
            this.packagesBasketDataGridView.AllowUserToDeleteRows = false;
            this.packagesBasketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packagesBasketDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packagesBasketDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.packagesBasketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packagesBasketDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.packagesBasketDataGridView.Location = new System.Drawing.Point(12, 12);
            this.packagesBasketDataGridView.Name = "packagesBasketDataGridView";
            this.packagesBasketDataGridView.ReadOnly = true;
            this.packagesBasketDataGridView.Size = new System.Drawing.Size(204, 409);
            this.packagesBasketDataGridView.TabIndex = 0;
            // 
            // issueButton
            // 
            this.issueButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueButton.Location = new System.Drawing.Point(69, 427);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(75, 23);
            this.issueButton.TabIndex = 1;
            this.issueButton.Text = "Issue";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // PackagesToIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 455);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.packagesBasketDataGridView);
            this.Name = "PackagesToIssueForm";
            this.Text = "Packages to issue";
            this.Load += new System.EventHandler(this.PackagesToIssueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBasketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView packagesBasketDataGridView;
        private System.Windows.Forms.Button issueButton;
    }
}