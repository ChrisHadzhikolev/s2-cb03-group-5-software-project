using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductForm : Form
    {
        string _name;
        ListBox _listBox;
        Product _productToBeEdited;
        private bool _editProduct;
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(string productName)
        {
            InitializeComponent();
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
                if (!string.IsNullOrWhiteSpace(nameTb.Text) && !string.IsNullOrWhiteSpace(priceTb.Text)&& !string.IsNullOrWhiteSpace(quantityTb.Text))
                {
                    if (typeCb.SelectedIndex>-1)
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
                            _productToBeEdited.Category =type;
                            DatabaseFunctions.UpdateProduct(_productToBeEdited);

                        }
                        else
                        {
                            Product newProduct = new Product(productName,type,productPrice,productQuantity);
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
                MessageBox.Show("Error", "Connection unsuccessful, please restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Error", "Product is non-existent, please restart", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.TextLength > 0)
            {

                if (typeCb.SelectedIndex > -1 && availableCkb.Checked && quantityTb.TextLength >= 1)
                {
                    if (nameTb.Text == _name) //check if the name put in the textbox is in the listbox 
                    {
                        _listBox.Items.Remove(_name);
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty fields.");
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty fields.");
            }
        }

        private void confirmBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
