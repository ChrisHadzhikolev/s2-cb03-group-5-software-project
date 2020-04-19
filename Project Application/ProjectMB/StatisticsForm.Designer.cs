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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductCategories = new System.Windows.Forms.ComboBox();
            this.btnGetProductStatistics = new System.Windows.Forms.Button();
            this.cbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.btnEmployeeStatistics = new System.Windows.Forms.Button();
            this.lbStatistics = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Department:";
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
            this.cbProductCategories.Location = new System.Drawing.Point(596, 352);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(146, 21);
            this.cbProductCategories.TabIndex = 11;
            // 
            // btnGetProductStatistics
            // 
            this.btnGetProductStatistics.Location = new System.Drawing.Point(501, 393);
            this.btnGetProductStatistics.Name = "btnGetProductStatistics";
            this.btnGetProductStatistics.Size = new System.Drawing.Size(241, 36);
            this.btnGetProductStatistics.TabIndex = 10;
            this.btnGetProductStatistics.Text = "Product Statistics";
            this.btnGetProductStatistics.UseVisualStyleBackColor = true;
            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Items.AddRange(new object[] {
            "Finances",
            "Human Resources",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(178, 352);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbEmployeeDepartment.TabIndex = 9;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(58, 393);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(241, 36);
            this.btnEmployeeStatistics.TabIndex = 8;
            this.btnEmployeeStatistics.Text = "Employee Statistics";
            this.btnEmployeeStatistics.UseVisualStyleBackColor = true;
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 16;
            this.lbStatistics.Location = new System.Drawing.Point(12, 21);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(776, 308);
            this.lbStatistics.TabIndex = 7;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.Button btnGetProductStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ListBox lbStatistics;
    }
}