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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void btnEmployeeStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.Items.Clear();
            string departmentName = cbEmployeeDepartment.SelectedItem.ToString();
            double avgSalary = 0;
            int employees = Users.Employees.Count;

            DatabaseFunctions.GetEmployeesByDepartment(departmentName);
            foreach(User user in Users.Employees)
            {
                avgSalary += user.Salary;
            }
            lbStatistics.Items.Add($"The average salary for the department {departmentName} is " + avgSalary / employees);
        }
    }
}
