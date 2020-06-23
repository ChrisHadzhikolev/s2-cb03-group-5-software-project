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
            this.titleLbl = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.btnGetOrderHistory = new System.Windows.Forms.Button();
            this.productLbl = new System.Windows.Forms.Label();
            this.topLbl = new System.Windows.Forms.Label();
            this.bottomLbl = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.leftLbl = new System.Windows.Forms.Label();
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
            this.finalizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.finalizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.finalizeBtn.Location = new System.Drawing.Point(486, 502);
            this.finalizeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Size = new System.Drawing.Size(121, 45);
            this.finalizeBtn.TabIndex = 1;
            this.finalizeBtn.Text = "Finalize Order";
            this.finalizeBtn.UseVisualStyleBackColor = false;
            this.finalizeBtn.Click += new System.EventHandler(this.finalizeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancelBtn.Location = new System.Drawing.Point(359, 502);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 45);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.closeBtn.Location = new System.Drawing.Point(232, 502);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 45);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // productTb
            // 
            this.productTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productTb.Location = new System.Drawing.Point(129, 188);
            this.productTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productTb.Name = "productTb";
            this.productTb.Size = new System.Drawing.Size(351, 32);
            this.productTb.TabIndex = 4;
            this.productTb.TextChanged += new System.EventHandler(this.productTb_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addBtn.Location = new System.Drawing.Point(486, 329);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 45);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericUpDown1.Location = new System.Drawing.Point(486, 191);
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
            this.numericUpDown1.Size = new System.Drawing.Size(123, 28);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueTb
            // 
            this.valueTb.Enabled = false;
            this.valueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.valueTb.Location = new System.Drawing.Point(35, 269);
            this.valueTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(165, 32);
            this.valueTb.TabIndex = 7;
            this.valueTb.Text = "Value";
            // 
            // categoryTb
            // 
            this.categoryTb.Enabled = false;
            this.categoryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.categoryTb.Location = new System.Drawing.Point(235, 269);
            this.categoryTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(374, 32);
            this.categoryTb.TabIndex = 9;
            this.categoryTb.Text = "Category";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(161, 41);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(208, 37);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Cashier Desk";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.removeBtn.Location = new System.Drawing.Point(359, 329);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(121, 45);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // btnGetOrderHistory
            // 
            this.btnGetOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnGetOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGetOrderHistory.Location = new System.Drawing.Point(437, 33);
            this.btnGetOrderHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetOrderHistory.Name = "btnGetOrderHistory";
            this.btnGetOrderHistory.Size = new System.Drawing.Size(121, 45);
            this.btnGetOrderHistory.TabIndex = 13;
            this.btnGetOrderHistory.Text = "Orders";
            this.btnGetOrderHistory.UseVisualStyleBackColor = false;
            this.btnGetOrderHistory.Click += new System.EventHandler(this.btnGetOrderHistory_Click);
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productLbl.Location = new System.Drawing.Point(30, 191);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(93, 26);
            this.productLbl.TabIndex = 14;
            this.productLbl.Text = "Product:";
            // 
            // topLbl
            // 
            this.topLbl.BackColor = System.Drawing.Color.Black;
            this.topLbl.Location = new System.Drawing.Point(0, 0);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(1066, 1);
            this.topLbl.TabIndex = 15;
            // 
            // bottomLbl
            // 
            this.bottomLbl.BackColor = System.Drawing.Color.Black;
            this.bottomLbl.Location = new System.Drawing.Point(0, 561);
            this.bottomLbl.Name = "bottomLbl";
            this.bottomLbl.Size = new System.Drawing.Size(1066, 1);
            this.bottomLbl.TabIndex = 16;
            // 
            // rightLbl
            // 
            this.rightLbl.BackColor = System.Drawing.Color.Black;
            this.rightLbl.Location = new System.Drawing.Point(1065, 0);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(1, 562);
            this.rightLbl.TabIndex = 17;
            this.rightLbl.Text = "label5";
            // 
            // leftLbl
            // 
            this.leftLbl.BackColor = System.Drawing.Color.Black;
            this.leftLbl.Location = new System.Drawing.Point(0, 0);
            this.leftLbl.Name = "leftLbl";
            this.leftLbl.Size = new System.Drawing.Size(1, 562);
            this.leftLbl.TabIndex = 18;
            this.leftLbl.Text = "label6";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.leftLbl);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.bottomLbl);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.btnGetOrderHistory);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.titleLbl);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button btnGetOrderHistory;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Label bottomLbl;
        private System.Windows.Forms.Label rightLbl;
        private System.Windows.Forms.Label leftLbl;
    }
}