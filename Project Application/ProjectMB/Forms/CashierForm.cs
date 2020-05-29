using Org.BouncyCastle.Crypto.Engines;
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
        double overall = 0;
        public CashierForm()
        {
            InitializeComponent();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
            List<string> names = new List<string>();
            DatabaseFunctions.GetAllProducts();
            foreach (var item in Products.products)
            {
                names.Add(item.Name);
                MessageBox.Show(item.ToString());
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
            if (Products.FindProduct(productTb.Text) != null) 
            {
                Product product = Products.FindProduct(productTb.Text);
                overall += product.Price * (double) numericUpDown1.Value;
                for (int i = 0; i < numericUpDown1.Value; i++) 
                {
                    itemsLb.Items.Add(productTb.Text);
                }
            }
            else
            {
                MessageBox.Show("No such product");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            itemsLb.Items.Clear();
        }

        private void finalizeBtn_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("The order has been finalized the total price is " + overall.ToString("C2"));
            overall = 0;
            receiptBtn.Visible = true;
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

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            receiptBtn.Enabled = false;
        }

        private void CashierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }
    }
}
