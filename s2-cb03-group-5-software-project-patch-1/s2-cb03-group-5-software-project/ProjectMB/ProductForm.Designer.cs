﻿namespace ProjectMB
{
    partial class ProductForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.availableCkb = new System.Windows.Forms.CheckBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cancelBtn.Location = new System.Drawing.Point(13, 552);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(278, 106);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmBtn.Location = new System.Drawing.Point(710, 552);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(278, 106);
            this.confirmBtn.TabIndex = 34;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // typeCb
            // 
            this.typeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Location = new System.Drawing.Point(318, 301);
            this.typeCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(670, 45);
            this.typeCb.TabIndex = 33;
            // 
            // availableCkb
            // 
            this.availableCkb.AutoSize = true;
            this.availableCkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.availableCkb.Location = new System.Drawing.Point(318, 376);
            this.availableCkb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.availableCkb.Name = "availableCkb";
            this.availableCkb.Size = new System.Drawing.Size(172, 41);
            this.availableCkb.TabIndex = 32;
            this.availableCkb.Text = "Available";
            this.availableCkb.UseVisualStyleBackColor = true;
            // 
            // quantityTb
            // 
            this.quantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.quantityTb.Location = new System.Drawing.Point(318, 461);
            this.quantityTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(670, 44);
            this.quantityTb.TabIndex = 31;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.quantityLbl.Location = new System.Drawing.Point(59, 461);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(145, 37);
            this.quantityLbl.TabIndex = 30;
            this.quantityLbl.Text = "Quantity:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.typeLbl.Location = new System.Drawing.Point(61, 301);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(96, 37);
            this.typeLbl.TabIndex = 29;
            this.typeLbl.Text = "Type:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.priceLbl.Location = new System.Drawing.Point(59, 216);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(98, 37);
            this.priceLbl.TabIndex = 28;
            this.priceLbl.Text = "Price:";
            // 
            // priceTb
            // 
            this.priceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.priceTb.Location = new System.Drawing.Point(318, 216);
            this.priceTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(670, 44);
            this.priceTb.TabIndex = 27;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameLbl.Location = new System.Drawing.Point(59, 140);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(112, 37);
            this.nameLbl.TabIndex = 26;
            this.nameLbl.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameTb.Location = new System.Drawing.Point(318, 136);
            this.nameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(670, 44);
            this.nameTb.TabIndex = 25;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(449, 552);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(254, 106);
            this.removeBtn.TabIndex = 36;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.availableCkb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.CheckBox availableCkb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button removeBtn;
    }
}