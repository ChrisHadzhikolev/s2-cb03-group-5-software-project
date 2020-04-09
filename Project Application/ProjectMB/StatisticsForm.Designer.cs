namespace ProjectMB
{
    partial class StatisticsForm
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
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.btnEmployeeStatistics = new System.Windows.Forms.Button();
            this.cbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 37;
            this.lbStatistics.Location = new System.Drawing.Point(18, 35);
            this.lbStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(1162, 374);
            this.lbStatistics.TabIndex = 0;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(18, 554);
            this.btnEmployeeStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(218, 56);
            this.btnEmployeeStatistics.TabIndex = 1;
            this.btnEmployeeStatistics.Text = "Employee Statistics";
            this.btnEmployeeStatistics.UseVisualStyleBackColor = true;
            this.btnEmployeeStatistics.Click += new System.EventHandler(this.btnEmployeeStatistics_Click);
            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Items.AddRange(new object[] {
            "Finance",
            "Human Resources",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(18, 491);
            this.cbEmployeeDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(180, 28);
            this.cbEmployeeDepartment.TabIndex = 2;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cbEmployeeDepartment);
            this.Controls.Add(this.btnEmployeeStatistics);
            this.Controls.Add(this.lbStatistics);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
    }
}