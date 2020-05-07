namespace ProjectMB
{
    partial class DepartmentsForm
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
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.searchDepartmentBtn = new System.Windows.Forms.Button();
            this.departmentsLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.Location = new System.Drawing.Point(951, 582);
            this.addDepartmentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(366, 114);
            this.addDepartmentBtn.TabIndex = 5;
            this.addDepartmentBtn.Text = "Add New Department";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtn_Click);
            // 
            // searchDepartmentBtn
            // 
            this.searchDepartmentBtn.Location = new System.Drawing.Point(57, 582);
            this.searchDepartmentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDepartmentBtn.Name = "searchDepartmentBtn";
            this.searchDepartmentBtn.Size = new System.Drawing.Size(366, 114);
            this.searchDepartmentBtn.TabIndex = 4;
            this.searchDepartmentBtn.Text = "Search for a Department";
            this.searchDepartmentBtn.UseVisualStyleBackColor = true;
            this.searchDepartmentBtn.Click += new System.EventHandler(this.searchDepartmentBtn_Click);
            // 
            // departmentsLb
            // 
            this.departmentsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsLb.FormattingEnabled = true;
            this.departmentsLb.ItemHeight = 37;
            this.departmentsLb.Location = new System.Drawing.Point(57, 18);
            this.departmentsLb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentsLb.Name = "departmentsLb";
            this.departmentsLb.Size = new System.Drawing.Size(1258, 448);
            this.departmentsLb.TabIndex = 3;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 731);
            this.Controls.Add(this.addDepartmentBtn);
            this.Controls.Add(this.searchDepartmentBtn);
            this.Controls.Add(this.departmentsLb);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentsForm";
            this.Text = "DepartmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentsForm_FormClosing);
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.Button searchDepartmentBtn;
        private System.Windows.Forms.ListBox departmentsLb;
    }
}