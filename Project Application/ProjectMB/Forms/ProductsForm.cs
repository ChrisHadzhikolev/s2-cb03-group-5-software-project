using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductsForm : Form
    {

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
        public ProductsForm()
        {
            InitializeComponent();
            //productsLb.SelectedValueChanged += new EventHandler(ProductLb_SelectedValueChanged);
            Timer timer = new Timer
            {
                Interval = 5000
            };
            timer.Enabled = true;
            //timer.Tick += OnTimerEvent;
        }
        //private void OnTimerEvent(object sender, EventArgs e)
        //{
        //    productsLw.Items.Clear();
        //    foreach (var item in Products.products)
        //    {
        //        ListViewItem lvi = new ListViewItem(item.id.ToString());
        //        lvi.SubItems.Add(item.Name);
        //        lvi.SubItems.Add(item.Category.ToString());
        //        lvi.SubItems.Add(item.Quantity.ToString());
        //        lvi.SubItems.Add(item.Price.ToString("C2", CultureInfo.CurrentCulture));
        //        if (item.StockRequest)
        //        {
        //            lvi.SubItems.Add("Yes");
        //        }
        //        else
        //        {
        //            lvi.SubItems.Add("No");
        //        }
                            
        //        productsLw.Items.Add(lvi);
        //    }
        //}
      
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.addBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.addBtn.FlatStyle = FlatStyle.Flat;
            this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.searchBtn.FlatStyle = FlatStyle.Flat; 
            this.BackColor = Color.FromArgb(193, 162, 254);
            try
            {
                DatabaseFunctions.GetAllProducts();
                productsLw.Items.Clear();
                foreach (var item in Products.products)
                {
                    ListViewItem lvi = new ListViewItem(item.id.ToString());
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.StockRequest.ToString());
                    lvi.SubItems.Add(item.Price.ToString("C2", CultureInfo.CurrentCulture));
                    productsLw.Items.Add(lvi);
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
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);

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

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void productsLw_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = Products.FindProduct(int.Parse(productsLw.SelectedItems[0].SubItems[0].Text));
                if (product != null)
                {
                    ProductForm productForm = new ProductForm(product);
                    productForm.Show();
                }
                else
                {
                    MessageBox.Show("Couldn't find the user, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
}

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (categoryCb.SelectedIndex > 0)
            {                
                productsLw.Items.Clear();
                foreach (var item in Products.FindProducts((ProductCategory)Enum.Parse(typeof(ProductCategory), (categoryCb.Text).Trim(), true)))
                {
                    ListViewItem lvi = new ListViewItem(item.id.ToString());
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.StockRequest.ToString());
                    lvi.SubItems.Add(item.Price.ToString("C2", CultureInfo.CurrentCulture));
                    productsLw.Items.Add(lvi);

                }
            }
        }
    }
}
