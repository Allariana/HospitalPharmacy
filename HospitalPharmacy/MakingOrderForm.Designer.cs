namespace HospitalPharmacy
{
    partial class MakingOrderForm
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
            this.tradeNameLabel = new System.Windows.Forms.Label();
            this.tradeNameComboBox = new System.Windows.Forms.ComboBox();
            this.doseLabel = new System.Windows.Forms.Label();
            this.doseComboBox = new System.Windows.Forms.ComboBox();
            this.doseTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.medicinesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // tradeNameLabel
            // 
            this.tradeNameLabel.AutoSize = true;
            this.tradeNameLabel.Location = new System.Drawing.Point(22, 24);
            this.tradeNameLabel.Name = "tradeNameLabel";
            this.tradeNameLabel.Size = new System.Drawing.Size(69, 13);
            this.tradeNameLabel.TabIndex = 0;
            this.tradeNameLabel.Text = "Trade Name:";
            // 
            // tradeNameComboBox
            // 
            this.tradeNameComboBox.FormattingEnabled = true;
            this.tradeNameComboBox.Location = new System.Drawing.Point(114, 16);
            this.tradeNameComboBox.Name = "tradeNameComboBox";
            this.tradeNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.tradeNameComboBox.TabIndex = 1;
            this.tradeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doseLabel
            // 
            this.doseLabel.AutoSize = true;
            this.doseLabel.Location = new System.Drawing.Point(22, 57);
            this.doseLabel.Name = "doseLabel";
            this.doseLabel.Size = new System.Drawing.Size(58, 13);
            this.doseLabel.TabIndex = 2;
            this.doseLabel.Text = "Dose [mg]:";
            // 
            // doseComboBox
            // 
            this.doseComboBox.FormattingEnabled = true;
            this.doseComboBox.Location = new System.Drawing.Point(114, 49);
            this.doseComboBox.Name = "doseComboBox";
            this.doseComboBox.Size = new System.Drawing.Size(121, 21);
            this.doseComboBox.TabIndex = 3;
            this.doseComboBox.SelectedIndexChanged += new System.EventHandler(this.doseComboBox_SelectedIndexChanged);
            // 
            // doseTextBox
            // 
            this.doseTextBox.Location = new System.Drawing.Point(114, 85);
            this.doseTextBox.Name = "doseTextBox";
            this.doseTextBox.Size = new System.Drawing.Size(121, 20);
            this.doseTextBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(22, 120);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(89, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity per Unit:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // medicinesCheckedListBox
            // 
            this.medicinesCheckedListBox.FormattingEnabled = true;
            this.medicinesCheckedListBox.Location = new System.Drawing.Point(274, 16);
            this.medicinesCheckedListBox.Name = "medicinesCheckedListBox";
            this.medicinesCheckedListBox.Size = new System.Drawing.Size(492, 244);
            this.medicinesCheckedListBox.TabIndex = 11;
            this.medicinesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // MakingOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medicinesCheckedListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.doseTextBox);
            this.Controls.Add(this.doseComboBox);
            this.Controls.Add(this.doseLabel);
            this.Controls.Add(this.tradeNameComboBox);
            this.Controls.Add(this.tradeNameLabel);
            this.Name = "MakingOrderForm";
            this.Text = "Make an Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tradeNameLabel;
        private System.Windows.Forms.ComboBox tradeNameComboBox;
        private System.Windows.Forms.Label doseLabel;
        private System.Windows.Forms.ComboBox doseComboBox;
        private System.Windows.Forms.TextBox doseTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox medicinesCheckedListBox;
    }
}