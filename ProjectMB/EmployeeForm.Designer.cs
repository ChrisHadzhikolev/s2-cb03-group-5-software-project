namespace ProjectMB
{
    partial class EmployeeForm
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
            this.shiftCb = new System.Windows.Forms.ComboBox();
            this.workingHLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.daysBtn = new System.Windows.Forms.Button();
            this.removeEmpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shiftCb
            // 
            this.shiftCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftCb.FormattingEnabled = true;
            this.shiftCb.Items.AddRange(new object[] {
            "Day Shift",
            "Half-Day Shift",
            "Night Shift"});
            this.shiftCb.Location = new System.Drawing.Point(617, 285);
            this.shiftCb.Name = "shiftCb";
            this.shiftCb.Size = new System.Drawing.Size(250, 45);
            this.shiftCb.TabIndex = 27;
            // 
            // workingHLbl
            // 
            this.workingHLbl.AutoSize = true;
            this.workingHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHLbl.Location = new System.Drawing.Point(31, 293);
            this.workingHLbl.Name = "workingHLbl";
            this.workingHLbl.Size = new System.Drawing.Size(231, 37);
            this.workingHLbl.TabIndex = 26;
            this.workingHLbl.Text = "Working Hours";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 359);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(250, 85);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(617, 359);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(250, 85);
            this.confirmBtn.TabIndex = 24;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // typeCb
            // 
            this.typeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Location = new System.Drawing.Point(264, 158);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(603, 45);
            this.typeCb.TabIndex = 23;
            // 
            // quantityTb
            // 
            this.quantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTb.Location = new System.Drawing.Point(264, 226);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(603, 44);
            this.quantityTb.TabIndex = 22;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(31, 226);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(116, 37);
            this.quantityLbl.TabIndex = 21;
            this.quantityLbl.Text = "Salary:";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(31, 161);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(140, 37);
            this.positionLbl.TabIndex = 20;
            this.positionLbl.Text = "Position:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(31, 90);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(106, 37);
            this.emailLbl.TabIndex = 19;
            this.emailLbl.Text = "Email:";
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(264, 90);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(603, 44);
            this.emailTb.TabIndex = 18;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(31, 29);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(112, 37);
            this.nameLbl.TabIndex = 17;
            this.nameLbl.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(264, 26);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(603, 44);
            this.nameTb.TabIndex = 16;
            // 
            // daysBtn
            // 
            this.daysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysBtn.Location = new System.Drawing.Point(388, 285);
            this.daysBtn.Name = "daysBtn";
            this.daysBtn.Size = new System.Drawing.Size(223, 45);
            this.daysBtn.TabIndex = 28;
            this.daysBtn.Text = "Days";
            this.daysBtn.UseVisualStyleBackColor = true;
            this.daysBtn.Click += new System.EventHandler(this.daysBtn_Click);
            // 
            // removeEmpBtn
            // 
            this.removeEmpBtn.Location = new System.Drawing.Point(388, 359);
            this.removeEmpBtn.Name = "removeEmpBtn";
            this.removeEmpBtn.Size = new System.Drawing.Size(223, 85);
            this.removeEmpBtn.TabIndex = 29;
            this.removeEmpBtn.Text = "Remove";
            this.removeEmpBtn.UseVisualStyleBackColor = true;
            this.removeEmpBtn.Click += new System.EventHandler(this.removeEmpBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.removeEmpBtn);
            this.Controls.Add(this.daysBtn);
            this.Controls.Add(this.shiftCb);
            this.Controls.Add(this.workingHLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTb);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shiftCb;
        private System.Windows.Forms.Label workingHLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button daysBtn;
        private System.Windows.Forms.Button removeEmpBtn;
    }
}