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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            employeesLb.SelectedValueChanged += new EventHandler(EmployeesLb_SelectedValueChanged);
        }

        protected void EmployeesLb_SelectedValueChanged(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(employeesLb.SelectedItem.ToString());
            employeeForm.Show();
        }
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(ManageType.EMPLOYEE);
            searchForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }
    }
}
