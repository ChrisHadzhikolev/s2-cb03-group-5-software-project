using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
            int[] shifts = new int[3];
            int favouriteShift = 0;
            DatabaseFunctions.GetEmployeesByDepartment(departmentName);
            int employees = Users.Employees.Count;
            foreach (User user in Users.Employees)
            {
                avgSalary += user.Salary;
                if(user.ShiftTypeU == ShiftType.DAY)
                {
                    shifts[0]++;
                }
                else if(user.ShiftTypeU == ShiftType.NIGHT)
                {
                    shifts[1]++;
                }
                else if (user.ShiftTypeU == ShiftType.HALFDAY)
                {
                    shifts[2]++;
                }
            }
            favouriteShift = shifts.Max();
            int index = Array.IndexOf(shifts, favouriteShift);
            lbStatistics.Items.Add($"The average salary for the department {departmentName} is: {(avgSalary / employees).ToString("C2", CultureInfo.CurrentCulture)}");
            lbStatistics.Items.Add($"The favourite shift of employees is: {(ShiftType)index}");
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.btnEmployeeStatistics.BackColor = Color.FromArgb(5, 179, 245);
            this.btnEmployeeStatistics.FlatStyle = FlatStyle.Flat;
            //this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            //this.searchBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
        }
    }
}
