namespace ProjectMB
{
    partial class DepartmentForm
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
            this.contentPnl = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.firstNamePnl = new System.Windows.Forms.Panel();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.leftPnl = new System.Windows.Forms.Panel();
            this.namePb = new System.Windows.Forms.PictureBox();
            this.topLbl = new System.Windows.Forms.Label();
            this.bottomLbl = new System.Windows.Forms.Label();
            this.topLeftLbl = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.leftLbl = new System.Windows.Forms.Label();
            this.bottomLeftLbl = new System.Windows.Forms.Label();
            this.contentPnl.SuspendLayout();
            this.leftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPnl
            // 
            this.contentPnl.BackColor = System.Drawing.Color.White;
            this.contentPnl.Controls.Add(this.rightLbl);
            this.contentPnl.Controls.Add(this.bottomLbl);
            this.contentPnl.Controls.Add(this.topLbl);
            this.contentPnl.Controls.Add(this.removeBtn);
            this.contentPnl.Controls.Add(this.cancelBtn);
            this.contentPnl.Controls.Add(this.titleLbl);
            this.contentPnl.Controls.Add(this.firstNamePnl);
            this.contentPnl.Controls.Add(this.confirmBtn);
            this.contentPnl.Controls.Add(this.NameTb);
            this.contentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPnl.Location = new System.Drawing.Point(567, 0);
            this.contentPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(583, 374);
            this.contentPnl.TabIndex = 5;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.removeBtn.Enabled = false;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Location = new System.Drawing.Point(296, 299);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(121, 45);
            this.removeBtn.TabIndex = 14;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(167, 299);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 45);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(189, 37);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(194, 29);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "New Department";
            // 
            // firstNamePnl
            // 
            this.firstNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.firstNamePnl.Location = new System.Drawing.Point(99, 228);
            this.firstNamePnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNamePnl.Name = "firstNamePnl";
            this.firstNamePnl.Size = new System.Drawing.Size(376, 2);
            this.firstNamePnl.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Location = new System.Drawing.Point(425, 299);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(121, 45);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // NameTb
            // 
            this.NameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTb.Location = new System.Drawing.Point(99, 189);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(376, 19);
            this.NameTb.TabIndex = 0;
            this.NameTb.Text = "Name";
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(162)))), ((int)(((byte)(254)))));
            this.leftPnl.Controls.Add(this.bottomLeftLbl);
            this.leftPnl.Controls.Add(this.leftLbl);
            this.leftPnl.Controls.Add(this.namePb);
            this.leftPnl.Controls.Add(this.topLeftLbl);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(567, 374);
            this.leftPnl.TabIndex = 4;
            // 
            // namePb
            // 
            this.namePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.namePb.Image = global::ProjectMB.Properties.Resources.emp_add;
            this.namePb.Location = new System.Drawing.Point(42, 18);
            this.namePb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namePb.Name = "namePb";
            this.namePb.Size = new System.Drawing.Size(484, 326);
            this.namePb.TabIndex = 0;
            this.namePb.TabStop = false;
            // 
            // topLbl
            // 
            this.topLbl.BackColor = System.Drawing.Color.Black;
            this.topLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLbl.Location = new System.Drawing.Point(0, 0);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(583, 1);
            this.topLbl.TabIndex = 15;
            // 
            // bottomLbl
            // 
            this.bottomLbl.BackColor = System.Drawing.Color.Black;
            this.bottomLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLbl.Location = new System.Drawing.Point(0, 373);
            this.bottomLbl.Name = "bottomLbl";
            this.bottomLbl.Size = new System.Drawing.Size(583, 1);
            this.bottomLbl.TabIndex = 16;
            // 
            // topLeftLbl
            // 
            this.topLeftLbl.BackColor = System.Drawing.Color.Black;
            this.topLeftLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeftLbl.Location = new System.Drawing.Point(0, 0);
            this.topLeftLbl.Name = "topLeftLbl";
            this.topLeftLbl.Size = new System.Drawing.Size(567, 1);
            this.topLeftLbl.TabIndex = 17;
            // 
            // rightLbl
            // 
            this.rightLbl.BackColor = System.Drawing.Color.Black;
            this.rightLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightLbl.Location = new System.Drawing.Point(582, 1);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(1, 372);
            this.rightLbl.TabIndex = 18;
            // 
            // leftLbl
            // 
            this.leftLbl.BackColor = System.Drawing.Color.Black;
            this.leftLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLbl.Location = new System.Drawing.Point(0, 1);
            this.leftLbl.Name = "leftLbl";
            this.leftLbl.Size = new System.Drawing.Size(1, 373);
            this.leftLbl.TabIndex = 18;
            // 
            // bottomLeftLbl
            // 
            this.bottomLeftLbl.BackColor = System.Drawing.Color.Black;
            this.bottomLeftLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLeftLbl.Location = new System.Drawing.Point(1, 373);
            this.bottomLeftLbl.Name = "bottomLeftLbl";
            this.bottomLeftLbl.Size = new System.Drawing.Size(566, 1);
            this.bottomLeftLbl.TabIndex = 19;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 374);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentForm_FormClosing);
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.contentPnl.ResumeLayout(false);
            this.contentPnl.PerformLayout();
            this.leftPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel firstNamePnl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Panel leftPnl;
        private System.Windows.Forms.PictureBox namePb;
        private System.Windows.Forms.Label rightLbl;
        private System.Windows.Forms.Label bottomLbl;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Label bottomLeftLbl;
        private System.Windows.Forms.Label leftLbl;
        private System.Windows.Forms.Label topLeftLbl;
    }
}