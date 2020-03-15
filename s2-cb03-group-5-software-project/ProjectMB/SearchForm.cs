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
    public partial class SearchForm : Form
    {
        public SearchForm(ManageType type)
        {
            InitializeComponent();
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.searchBtn.FlatStyle = FlatStyle.Flat;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
