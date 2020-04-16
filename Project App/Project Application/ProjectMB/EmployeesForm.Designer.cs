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
            this.departmentCb = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1106, 427);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(272, 81);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 427);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(272, 81);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // employeesLb
            // 
            this.employeesLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesLb.FormattingEnabled = true;
            this.employeesLb.ItemHeight = 37;
            this.employeesLb.Location = new System.Drawing.Point(0, 0);
            this.employeesLb.Name = "employeesLb";
            this.employeesLb.Size = new System.Drawing.Size(1422, 370);
            this.employeesLb.TabIndex = 3;
            // 
            // departmentCb
            // 
            this.departmentCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            "Position",
            "Employee",
            "Stock",
            "Department",
            "All Employees",
            "All Managers",
            "All People"});
            this.departmentCb.Location = new System.Drawing.Point(667, 388);
            this.departmentCb.Name = "departmentCb";
            this.departmentCb.Size = new System.Drawing.Size(245, 40);
            this.departmentCb.TabIndex = 6;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.Location = new System.Drawing.Point(535, 434);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(245, 32);
            this.showBtn.TabIndex = 7;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = false;
            // 
            // roleCb
            // 
            this.roleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            "Department",
            "All Departments"});
            this.roleCb.Location = new System.Drawing.Point(416, 388);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(245, 40);
            this.roleCb.TabIndex = 8;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1289, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(101, 32);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 518);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.departmentCb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.employeesLb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox employeesLb;
        private System.Windows.Forms.ComboBox departmentCb;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ComboBox roleCb;
        private System.Windows.Forms.Button closeBtn;
    }
}