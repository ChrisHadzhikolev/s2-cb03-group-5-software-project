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
            employeesLb.SelectedValueChanged += EmployeesLb_SelectedValueChanged;
            Timer timer = new Timer    
            {    
                Interval = 2000    
            };    
            timer.Enabled = true;    
            timer.Tick += OnTimerEvent;  
        }
        private void OnTimerEvent(object sender, EventArgs e)    
        {    
            employeesLb.Items.Clear();
            foreach (var item in Users.Employees)
            {
                employeesLb.Items.Add(item.ToString());
            }    
        } 
        private void EmployeesLb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                EmployeeForm employeeForm = new EmployeeForm(Users.Employees[employeesLb.SelectedIndex]);
                employeeForm.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }
        private void EmployeesForm_Load(object sender, EventArgs e)
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
                DatabaseFunctions.GetEmployeesByDepartment(Users.Department);
                foreach (var item in Users.Employees)
                {
                    employeesLb.Items.Add(item.ToString());
                }
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Error", "Connection unsuccessful, please restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Error", "Department is non-existent, please restart", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
