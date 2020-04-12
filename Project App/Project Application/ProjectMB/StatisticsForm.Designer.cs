﻿namespace ProjectMB
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
            this.SuspendLayout();
            // 
            // lbStatistics
            // 
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStatistics.FormattingEnabled = true;
            this.lbStatistics.ItemHeight = 16;
            this.lbStatistics.Location = new System.Drawing.Point(12, 23);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(776, 276);
            this.lbStatistics.TabIndex = 0;
            // 
            // btnEmployeeStatistics
            // 
            this.btnEmployeeStatistics.Location = new System.Drawing.Point(12, 360);
            this.btnEmployeeStatistics.Name = "btnEmployeeStatistics";
            this.btnEmployeeStatistics.Size = new System.Drawing.Size(145, 36);
            this.btnEmployeeStatistics.TabIndex = 1;
            this.btnEmployeeStatistics.Text = "Employee Statistics";
            this.btnEmployeeStatistics.UseVisualStyleBackColor = true;
            this.btnEmployeeStatistics.Click += new System.EventHandler(this.btnEmployeeStatistics_Click);
            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.FormattingEnabled = true;
            this.cbEmployeeDepartment.Items.AddRange(new object[] {
            "Finances",
            "Human Resources",
            "Inventory",
            "Marketing"});
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(12, 319);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbEmployeeDepartment.TabIndex = 2;
            // 
            // btnGetProductStatistics
            // 
            this.btnGetProductStatistics.Location = new System.Drawing.Point(340, 360);
            this.btnGetProductStatistics.Name = "btnGetProductStatistics";
            this.btnGetProductStatistics.Size = new System.Drawing.Size(145, 36);
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
            this.cbProductCategories.Location = new System.Drawing.Point(340, 319);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(121, 21);
            this.cbProductCategories.TabIndex = 4;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbProductCategories);
            this.Controls.Add(this.btnGetProductStatistics);
            this.Controls.Add(this.cbEmployeeDepartment);
            this.Controls.Add(this.btnEmployeeStatistics);
            this.Controls.Add(this.lbStatistics);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatistics;
        private System.Windows.Forms.Button btnEmployeeStatistics;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Button btnGetProductStatistics;
        private System.Windows.Forms.ComboBox cbProductCategories;
    }
}