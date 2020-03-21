namespace ProjectMB
{
    partial class ProductsForm
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
            this.productsLb = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsLb
            // 
            this.productsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLb.FormattingEnabled = true;
            this.productsLb.ItemHeight = 37;
            this.productsLb.Location = new System.Drawing.Point(12, 12);
            this.productsLb.Name = "productsLb";
            this.productsLb.Size = new System.Drawing.Size(1256, 374);
            this.productsLb.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 392);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(244, 74);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search for a Product";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1024, 392);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(244, 74);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add New Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 470);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.productsLb);
            this.Name = "ProductsForm";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsLb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
    }
}