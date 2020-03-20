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
            resultsLb.SelectedValueChanged += new EventHandler(resultsLb_SelectedValueChanged);
        }
        private void resultsLb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                EmployeeForm employeeForm = new EmployeeForm(Users.Employees[resultsLb.SelectedIndex]);
                employeeForm.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }
        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.searchBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            resultsLb.Items.Clear();
            string input = searchTb.Text;
            foreach (var item in Users.Employees)
            {
                if (item.LastName == input)
                {
                    resultsLb.Items.Add(item.ToString());
                }
            }
        }
    }
}
