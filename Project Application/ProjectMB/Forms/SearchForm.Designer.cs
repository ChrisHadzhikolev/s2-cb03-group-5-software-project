﻿namespace ProjectMB
{
    partial class SearchForm
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
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultsLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.Location = new System.Drawing.Point(11, 288);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(520, 50);
            this.searchTb.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(535, 286);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(414, 54);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultsLb
            // 
            this.resultsLb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLb.FormattingEnabled = true;
            this.resultsLb.ItemHeight = 45;
            this.resultsLb.Location = new System.Drawing.Point(11, 10);
            this.resultsLb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsLb.Name = "resultsLb";
            this.resultsLb.Size = new System.Drawing.Size(939, 229);
            this.resultsLb.TabIndex = 2;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 365);
            this.Controls.Add(this.resultsLb);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Name = "SearchForm";
            this.Text = "Search By Surname";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox resultsLb;
    }
}