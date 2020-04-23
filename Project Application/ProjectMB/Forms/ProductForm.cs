using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductForm : Form
    {
        Product _productToBeEdited;
        private bool _editProduct;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public ProductForm(Product product)
        {
            InitializeComponent();
            _productToBeEdited = product;
            nameTb.Text = product.Name;
            priceTb.Text = product.Price.ToString();
            quantityTb.Text = product.Quantity.ToString();
            typeCb.Text = product.Category.ToString();
            _editProduct = true;
        }

        public ProductForm()
        {
            InitializeComponent();
            _editProduct = false;
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.cancelBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.cancelBtn.FlatStyle = FlatStyle.Flat;
            this.confirmBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.confirmBtn.FlatStyle = FlatStyle.Flat;
            this.removeBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.removeBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (availableCkb.Checked)
            {
                quantityTb.Enabled = true;
            }
            else
            {
                quantityTb.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(nameTb.Text) && !string.IsNullOrWhiteSpace(priceTb.Text) && !string.IsNullOrWhiteSpace(quantityTb.Text))
                {

                    if (typeCb.SelectedIndex > -1)
                    {
                        string productName = nameTb.Text;
                        double productPrice = double.Parse(priceTb.Text); ;
                        int productQuantity = int.Parse(quantityTb.Text);
                        ProductCategory type = (ProductCategory)Enum.Parse(typeof(ProductCategory), typeCb.Text, true);

                        if (_editProduct)
                        {
                            _productToBeEdited.Name = productName;
                            _productToBeEdited.Price = productPrice;
                            _productToBeEdited.Quantity = productQuantity;
                            _productToBeEdited.Category = type;
                            DatabaseFunctions.UpdateProduct(_productToBeEdited);
                        }
                        else
                        {
                            Product newProduct = new Product(productName, type, productPrice, productQuantity);
                            DatabaseFunctions.AddProduct(newProduct);
                        }
                        DatabaseFunctions.GetAllProducts();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Choose type!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty fields!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price and quantity must be numeric!");
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Product is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions.RemoveProduct(_productToBeEdited);
                DatabaseFunctions.GetAllProducts();
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Product is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }
    }
}
