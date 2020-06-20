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
            this.panel1 = new System.Windows.Forms.Panel();
            this.namePb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 24;
            this.lbStatistics.Location = new System.Drawing.Point(-1, 1);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(666, 268);
            this.lbStatistics.TabIndex = 0;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnEmployeeStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(206, 108);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(222, 36);
            this.btnEmployeeStatistics.TabIndex = 1;
            this.btnEmployeeStatistics.Text = "Employee Statistics";
            this.btnEmployeeStatistics.UseVisualStyleBackColor = false;
            this.btnEmployeeStatistics.Click += new System.EventHandler(this.btnEmployeeStatistics_Click);
            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Items.AddRange(new object[] {
            "Finance",
            "Human Resource",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(206, 49);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(223, 28);
            this.cbEmployeeDepartment.TabIndex = 2;
            // 
            // btnGetProductStatistics
            // 
            this.btnGetProductStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.btnGetProductStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetProductStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetProductStatistics.Location = new System.Drawing.Point(444, 108);
            this.btnGetProductStatistics.Name = "btnGetProductStatistics";
            this.btnGetProductStatistics.Size = new System.Drawing.Size(219, 36);
            this.btnGetProductStatistics.TabIndex = 3;
            this.btnGetProductStatistics.Text = "Product Statistics";
            this.btnGetProductStatistics.UseVisualStyleBackColor = false;
            this.btnGetProductStatistics.Click += new System.EventHandler(this.btnGetProductStatistics_Click);
            // 
            // cbProductCategories
            // 
            this.cbProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbProductCategories.Location = new System.Drawing.Point(444, 49);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(220, 28);
            this.cbProductCategories.TabIndex = 4;
            // 
            // lbStatisticsEdepartments
            // 
            this.lbStatisticsEdepartments.AutoSize = true;
            this.lbStatisticsEdepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatisticsEdepartments.Location = new System.Drawing.Point(206, 7);
            this.lbStatisticsEdepartments.Name = "lbStatisticsEdepartments";
            this.lbStatisticsEdepartments.Size = new System.Drawing.Size(155, 18);
            this.lbStatisticsEdepartments.TabIndex = 5;
            this.lbStatisticsEdepartments.Text = "Employee Department";
            // 
            // lbStatisticsProductCategory
            // 
            this.lbStatisticsProductCategory.AutoSize = true;
            this.lbStatisticsProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatisticsProductCategory.Location = new System.Drawing.Point(440, 7);
            this.lbStatisticsProductCategory.Name = "lbStatisticsProductCategory";
            this.lbStatisticsProductCategory.Size = new System.Drawing.Size(124, 18);
            this.lbStatisticsProductCategory.TabIndex = 6;
            this.lbStatisticsProductCategory.Text = "Product Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.namePb);
            this.panel1.Controls.Add(this.btnEmployeeStatistics);
            this.panel1.Controls.Add(this.lbStatisticsProductCategory);
            this.panel1.Controls.Add(this.cbEmployeeDepartment);
            this.panel1.Controls.Add(this.cbProductCategories);
            this.panel1.Controls.Add(this.lbStatisticsEdepartments);
            this.panel1.Controls.Add(this.btnGetProductStatistics);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(-1, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 177);
            this.panel1.TabIndex = 7;
            // 
            // namePb
            // 
            this.namePb.BackColor = System.Drawing.Color.Transparent;
            this.namePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namePb.Image = global::ProjectMB.Properties.Resources.emp_add;
            this.namePb.Location = new System.Drawing.Point(0, -23);
            this.namePb.Name = "namePb";
            this.namePb.Size = new System.Drawing.Size(200, 200);
            this.namePb.TabIndex = 8;
            this.namePb.TabStop = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Button btnGetProductStatistics;
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.Label lbStatisticsEdepartments;
        private System.Windows.Forms.Label lbStatisticsProductCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox namePb;
    }
}