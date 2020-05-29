namespace ProjectMB.Forms
{
    partial class CashierForm
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
            this.itemsLb = new System.Windows.Forms.ListBox();
            this.finalizeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.productTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.valueTb = new System.Windows.Forms.TextBox();
            this.categoryTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsLb
            // 
            this.itemsLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsLb.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemsLb.FormattingEnabled = true;
            this.itemsLb.ItemHeight = 25;
            this.itemsLb.Location = new System.Drawing.Point(630, 0);
            this.itemsLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsLb.Name = "itemsLb";
            this.itemsLb.Size = new System.Drawing.Size(436, 562);
            this.itemsLb.TabIndex = 0;
            // 
            // finalizeBtn
            // 
            this.finalizeBtn.Location = new System.Drawing.Point(499, 503);
            this.finalizeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Size = new System.Drawing.Size(123, 46);
            this.finalizeBtn.TabIndex = 1;
            this.finalizeBtn.Text = "Finalize";
            this.finalizeBtn.UseVisualStyleBackColor = true;
            this.finalizeBtn.Click += new System.EventHandler(this.finalizeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(369, 503);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 46);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(15, 503);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(123, 46);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // productTb
            // 
            this.productTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productTb.Location = new System.Drawing.Point(33, 185);
            this.productTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productTb.Name = "productTb";
            this.productTb.Size = new System.Drawing.Size(352, 30);
            this.productTb.TabIndex = 4;
            this.productTb.TextChanged += new System.EventHandler(this.productTb_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(458, 329);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 46);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(393, 190);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(159, 26);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueTb
            // 
            this.valueTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueTb.Enabled = false;
            this.valueTb.Location = new System.Drawing.Point(33, 269);
            this.valueTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(142, 23);
            this.valueTb.TabIndex = 7;
            this.valueTb.Text = "Value";
            // 
            // categoryTb
            // 
            this.categoryTb.Enabled = false;
            this.categoryTb.Location = new System.Drawing.Point(204, 269);
            this.categoryTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(374, 30);
            this.categoryTb.TabIndex = 9;
            this.categoryTb.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cashier Desk";
            // 
            // receiptBtn
            // 
            this.receiptBtn.Enabled = false;
            this.receiptBtn.Location = new System.Drawing.Point(499, 449);
            this.receiptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(123, 46);
            this.receiptBtn.TabIndex = 11;
            this.receiptBtn.Text = "Receipt";
            this.receiptBtn.UseVisualStyleBackColor = true;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTb);
            this.Controls.Add(this.valueTb);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productTb);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.finalizeBtn);
            this.Controls.Add(this.itemsLb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierForm_FormClosing);
            this.Load += new System.EventHandler(this.CashierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsLb;
        private System.Windows.Forms.Button finalizeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox productTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox valueTb;
        private System.Windows.Forms.TextBox categoryTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button receiptBtn;
    }
}