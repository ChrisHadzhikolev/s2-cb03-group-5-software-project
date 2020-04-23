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
            this.btnGetProductStatistics = new System.Windows.Forms.Button();
            this.cbProductCategories = new System.Windows.Forms.ComboBox();
            this.lbStatisticsEdepartments = new System.Windows.Forms.Label();
            this.lbStatisticsProductCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 16;
            this.lbStatistics.Location = new System.Drawing.Point(12, 23);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(629, 276);
            this.lbStatistics.TabIndex = 0;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(15, 360);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(238, 36);
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
            "Human Resource",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(132, 324);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbEmployeeDepartment.TabIndex = 2;
            // 
            // btnGetProductStatistics
            // 
            this.btnGetProductStatistics.Location = new System.Drawing.Point(403, 360);
            this.btnGetProductStatistics.Name = "btnGetProductStatistics";
            this.btnGetProductStatistics.Size = new System.Drawing.Size(238, 36);
            this.btnGetProductStatistics.TabIndex = 3;
            this.btnGetProductStatistics.Text = "Product Statistics";
            this.btnGetProductStatistics.UseVisualStyleBackColor = true;
            this.btnGetProductStatistics.Click += new System.EventHandler(this.btnGetProductStatistics_Click);
            // 
            // cbProductCategories
            // 
            this.cbProductCategories.FormattingEnabled = true;
            this.cbProductCategories.Items.AddRange(new object[] {
            "IMAGE_SOUND",
            "COMPUTER",
            "PHOTO_VIDEO",
            "TELEPHONY_NAVIGATION",
            "HOUSEHOLD",
            "KITCHEN",
            "SPORT_CARE",
            "GAMING_FILM_MUSIC",
            "SMART_HOME"});
            this.cbProductCategories.Location = new System.Drawing.Point(498, 324);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(143, 21);
            this.cbProductCategories.TabIndex = 4;
            // 
            // lbStatisticsEdepartments
            // 
            this.lbStatisticsEdepartments.AutoSize = true;
            this.lbStatisticsEdepartments.Location = new System.Drawing.Point(12, 327);
            this.lbStatisticsEdepartments.Name = "lbStatisticsEdepartments";
            this.lbStatisticsEdepartments.Size = new System.Drawing.Size(114, 13);
            this.lbStatisticsEdepartments.TabIndex = 5;
            this.lbStatisticsEdepartments.Text = "Employee Department:";
            // 
            // lbStatisticsProductCategory
            // 
            this.lbStatisticsProductCategory.AutoSize = true;
            this.lbStatisticsProductCategory.Location = new System.Drawing.Point(400, 327);
            this.lbStatisticsProductCategory.Name = "lbStatisticsProductCategory";
            this.lbStatisticsProductCategory.Size = new System.Drawing.Size(92, 13);
            this.lbStatisticsProductCategory.TabIndex = 6;
            this.lbStatisticsProductCategory.Text = "Product Category:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.lbStatisticsProductCategory);
            this.Controls.Add(this.lbStatisticsEdepartments);
            this.Controls.Add(this.cbProductCategories);
            this.Controls.Add(this.btnGetProductStatistics);
            this.Controls.Add(this.cbEmployeeDepartment);
            this.Controls.Add(this.btnEmployeeStatistics);
            this.Controls.Add(this.lbStatistics);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Button btnGetProductStatistics;
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.Label lbStatisticsEdepartments;
        private System.Windows.Forms.Label lbStatisticsProductCategory;
    }
}