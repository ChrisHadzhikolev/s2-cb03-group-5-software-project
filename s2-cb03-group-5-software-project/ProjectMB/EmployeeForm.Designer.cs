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
            this.salaryTb = new System.Windows.Forms.TextBox();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.daysBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shiftCb
            // 
            this.shiftCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.shiftCb.FormattingEnabled = true;
            this.shiftCb.Items.AddRange(new object[] {"DAY", "NIGHT", "HALFDAY"});
            this.shiftCb.Location = new System.Drawing.Point(686, 356);
            this.shiftCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shiftCb.Name = "shiftCb";
            this.shiftCb.Size = new System.Drawing.Size(277, 45);
            this.shiftCb.TabIndex = 27;
            // 
            // workingHLbl
            // 
            this.workingHLbl.AutoSize = true;
            this.workingHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.workingHLbl.Location = new System.Drawing.Point(34, 366);
            this.workingHLbl.Name = "workingHLbl";
            this.workingHLbl.Size = new System.Drawing.Size(201, 32);
            this.workingHLbl.TabIndex = 26;
            this.workingHLbl.Text = "Working Hours";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cancelBtn.Location = new System.Drawing.Point(13, 449);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(278, 106);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmBtn.Location = new System.Drawing.Point(686, 449);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(278, 106);
            this.confirmBtn.TabIndex = 24;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // salaryTb
            // 
            this.salaryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.salaryTb.Location = new System.Drawing.Point(293, 282);
            this.salaryTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryTb.Name = "salaryTb";
            this.salaryTb.Size = new System.Drawing.Size(670, 44);
            this.salaryTb.TabIndex = 22;
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.salaryLbl.Location = new System.Drawing.Point(34, 282);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(104, 32);
            this.salaryLbl.TabIndex = 21;
            this.salaryLbl.Text = "Salary:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastNameLbl.Location = new System.Drawing.Point(34, 116);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(159, 32);
            this.lastNameLbl.TabIndex = 20;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLbl.Location = new System.Drawing.Point(34, 198);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(95, 32);
            this.emailLbl.TabIndex = 19;
            this.emailLbl.Text = "Email:";
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastNameTb.Location = new System.Drawing.Point(293, 112);
            this.lastNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(670, 44);
            this.lastNameTb.TabIndex = 18;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.firstNameLbl.Location = new System.Drawing.Point(34, 36);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(160, 32);
            this.firstNameLbl.TabIndex = 17;
            this.firstNameLbl.Text = "First Name:";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.firstNameTb.Location = new System.Drawing.Point(293, 32);
            this.firstNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(670, 44);
            this.firstNameTb.TabIndex = 16;
            // 
            // daysBtn
            // 
            this.daysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.daysBtn.Location = new System.Drawing.Point(431, 356);
            this.daysBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daysBtn.Name = "daysBtn";
            this.daysBtn.Size = new System.Drawing.Size(248, 56);
            this.daysBtn.TabIndex = 28;
            this.daysBtn.Text = "Days";
            this.daysBtn.UseVisualStyleBackColor = true;
            this.daysBtn.Click += new System.EventHandler(this.daysBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(431, 449);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(248, 106);
            this.removeBtn.TabIndex = 29;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailTb.Location = new System.Drawing.Point(294, 198);
            this.emailTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(670, 44);
            this.emailTb.TabIndex = 30;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 589);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.daysBtn);
            this.Controls.Add(this.shiftCb);
            this.Controls.Add(this.workingHLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.salaryTb);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.firstNameTb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button daysBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.TextBox salaryTb;
    }
}