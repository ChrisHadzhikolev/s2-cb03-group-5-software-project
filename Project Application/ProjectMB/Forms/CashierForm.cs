using Org.BouncyCastle.Crypto.Engines;
using ProjectMB.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB.Forms
{
    public partial class CashierForm : Form
    {

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
        CashDesk cd;
        Order order;
        public CashierForm()
        {
            InitializeComponent();
            cd = new CashDesk();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
           
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
            List<string> names = new List<string>();
            DatabaseFunctions.GetAllProducts();
            foreach (var item in Products.products)
            {
                names.Add(item.Name);
            }
            var source = new AutoCompleteStringCollection();
            source.AddRange(names.ToArray());
            this.productTb.AutoCompleteCustomSource = source;
            this.productTb.AutoCompleteMode =
                          AutoCompleteMode.SuggestAppend;
            this.productTb.AutoCompleteSource =
                AutoCompleteSource.CustomSource;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Products.FindProduct(productTb.Text) != null)
                {
                    Product product = Products.FindProduct(productTb.Text);
                    //MessageBox.Show(product.ToString());
                    cd.AddItemToCart(product, (int) numericUpDown1.Value);
                    UpdateLb();
                }
                else
                {
                    MessageBox.Show("No such product");
                }
                
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured, please try again");
            }           
        }
        private void UpdateLb() 
        {
            itemsLb.Items.Clear();
            foreach (var item in cd.Cart)
            {
                itemsLb.Items.Add(item.Value + " x " + item.Key.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cd.Cart.Clear();
            UpdateLb();
        }

        private void finalizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                order = new Order(cd.Cart);
               
                Orders.NewOrder(order);
                DatabaseFunctions.AddOrder(order);
                MessageBox.Show("The order has been finalized the total price is " + cd.Purchase().ToString("C2"));
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);                
            }
           
        }

        private void productTb_TextChanged(object sender, EventArgs e)
        {
            if (Products.FindProduct(productTb.Text) != null)
            {
                Product product = Products.FindProduct(productTb.Text);
                categoryTb.Text = product.Category.ToString();
                valueTb.Text = product.Price.ToString("C2");
            }
        }

       

        private void CashierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Products.FindProduct(productTb.Text) != null)
                {
                    Product product = Products.FindProduct(productTb.Text);
                    cd.RemoveItemFromCart(product, (int)numericUpDown1.Value);
                    UpdateLb();
                }
                else
                {
                    MessageBox.Show("No such product");
                }

            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured, please try again");
            }
        }

        private void btnGetOrderHistory_Click(object sender, EventArgs e)
        {
            itemsLb.Items.Clear();
            DatabaseFunctions.GetAllOrders();
            foreach (Order order in Orders._orders)
            {
                string info = $"Order id: {order.Id} made on {order._timestamp} with total price: {order.GetTotalPrice().ToString("C2")}";
                itemsLb.Items.Add(info);
            }
        }
    }
}
