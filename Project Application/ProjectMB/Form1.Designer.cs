using System.Drawing;
using System.Windows.Forms;

namespace ProjectMB
{
    partial class MainForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginPnl = new System.Windows.Forms.Panel();
            this.loginComponentsPnl = new System.Windows.Forms.Panel();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.selectionPnl = new System.Windows.Forms.Panel();
            this.productsBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.loginPnl.SuspendLayout();
            this.loginComponentsPnl.SuspendLayout();
            this.selectionPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(36, 36);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(83, 26);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTb
            // 
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(0, 0);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(67, 23);
            this.usernameTb.TabIndex = 1;
            // 
            // passwordTb
            // 
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(0, 0);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(67, 23);
            this.passwordTb.TabIndex = 2;
            this.passwordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTb_KeyDown);
            // 
            // loginPnl
            // 
            this.loginPnl.BackColor = System.Drawing.Color.Transparent;
            this.loginPnl.Controls.Add(this.loginComponentsPnl);
            this.loginPnl.Location = new System.Drawing.Point(340, 68);
            this.loginPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(185, 159);
            this.loginPnl.TabIndex = 3;
            // 
            // loginComponentsPnl
            // 
            this.loginComponentsPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginComponentsPnl.BackColor = System.Drawing.Color.White;
            this.loginComponentsPnl.Controls.Add(this.passwordLbl);
            this.loginComponentsPnl.Controls.Add(this.usernameLbl);
            this.loginComponentsPnl.Controls.Add(this.passwordTb);
            this.loginComponentsPnl.Controls.Add(this.usernameTb);
            this.loginComponentsPnl.Controls.Add(this.loginBtn);
            this.loginComponentsPnl.Location = new System.Drawing.Point(26, 47);
            this.loginComponentsPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginComponentsPnl.Name = "loginComponentsPnl";
            this.loginComponentsPnl.Size = new System.Drawing.Size(149, 98);
            this.loginComponentsPnl.TabIndex = 5;
            // 
            // passwordLbl
            // 
            this.passwordLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.passwordLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordLbl.Location = new System.Drawing.Point(0, 96);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(149, 1);
            this.passwordLbl.TabIndex = 7;
            // 
            // usernameLbl
            // 
            this.usernameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usernameLbl.Location = new System.Drawing.Point(0, 97);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(149, 1);
            this.usernameLbl.TabIndex = 6;
            // 
            // selectionPnl
            // 
            this.selectionPnl.BackColor = System.Drawing.Color.Transparent;
            this.selectionPnl.Controls.Add(this.statisticsBtn);
            this.selectionPnl.Controls.Add(this.productsBtn);
            this.selectionPnl.Controls.Add(this.employeesBtn);
            this.selectionPnl.Location = new System.Drawing.Point(0, 0);
            this.selectionPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionPnl.Name = "selectionPnl";
            this.selectionPnl.Size = new System.Drawing.Size(185, 159);
            this.selectionPnl.TabIndex = 4;
            this.selectionPnl.Visible = false;
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(42, 54);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(61, 21);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.Location = new System.Drawing.Point(42, 20);
            this.employeesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(61, 17);
            this.employeesBtn.TabIndex = 1;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(757, 8);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 36);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(0, 0);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(50, 15);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Visible = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(42, 106);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(61, 23);
            this.statisticsBtn.TabIndex = 3;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 468);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selectionPnl);
            this.Controls.Add(this.loginPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.loginPnl.ResumeLayout(false);
            this.loginComponentsPnl.ResumeLayout(false);
            this.loginComponentsPnl.PerformLayout();
            this.selectionPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Panel selectionPnl;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Panel loginComponentsPnl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private Button statisticsBtn;
    }
}

