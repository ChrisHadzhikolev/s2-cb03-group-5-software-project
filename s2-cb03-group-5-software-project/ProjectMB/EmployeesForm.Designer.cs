namespace ProjectMB
{
    partial class EmployeesForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.employeesLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1138, 485);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(271, 92);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add New Employee";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 485);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(271, 92);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search for an Employee";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // employeesLb
            // 
            this.employeesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.employeesLb.FormattingEnabled = true;
            this.employeesLb.ItemHeight = 37;
            this.employeesLb.Location = new System.Drawing.Point(13, 10);
            this.employeesLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLb.Name = "employeesLb";
            this.employeesLb.Size = new System.Drawing.Size(1395, 448);
            this.employeesLb.TabIndex = 3;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 588);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.employeesLb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeesForm";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox employeesLb;
    }
}