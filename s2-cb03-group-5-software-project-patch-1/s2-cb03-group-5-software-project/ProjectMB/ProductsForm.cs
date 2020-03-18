using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            productsLb.SelectedValueChanged += new EventHandler(ProductLb_SelectedValueChanged);

        }
        protected void ProductLb_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(productsLb.SelectedItem.ToString());
            productForm.Show();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.addBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.addBtn.FlatStyle = FlatStyle.Flat;
            this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.searchBtn.FlatStyle = FlatStyle.Flat; 
            this.BackColor = Color.FromArgb(193, 162, 254);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchProductForm = new SearchForm(ManageType.PRODUCT);
            searchProductForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductForm newProductForm = new ProductForm();
            newProductForm.Show();
        }
    }
}
