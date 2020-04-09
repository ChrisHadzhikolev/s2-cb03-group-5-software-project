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
            Timer timer = new Timer
            {
                Interval = 2000
            };
            timer.Enabled = true;
            timer.Tick += OnTimerEvent;
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            productsLb.Items.Clear();
            foreach (var item in Products.products)
            {
                productsLb.Items.Add(item.Name);
            }
        }
        protected void ProductLb_SelectedValueChanged(object sender, EventArgs e)
        {
            try { 
                ProductForm productForm = new ProductForm(Products.products[productsLb.SelectedIndex]);
            productForm.Show();
        }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

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
            try
            {
                DatabaseFunctions.GetAllProducts();
                foreach (var item in Products.products)
                {
                    productsLb.Items.Add(item.Name);
                }
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Department is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
