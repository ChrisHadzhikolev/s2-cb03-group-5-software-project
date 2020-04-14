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
    public partial class DepartmentForm : Form
    {
        Department _departmentToBeEdited;
        private bool _editDepartment;
        public DepartmentForm(Department department)
        {
            InitializeComponent();
            _departmentToBeEdited = department;
            NameTb.Text = department.Name;
            _editDepartment = true;

        }
        public DepartmentForm()
        {
            InitializeComponent();
            _editDepartment = false;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NameTb.Text))
                {
                    string departmentName = NameTb.Text;
                    if (_editDepartment)
                    {
                        _departmentToBeEdited.Name = departmentName;
                        DatabaseFunctions.UpdateDepartment(_departmentToBeEdited);
                    }
                    else
                    {
                        Department newDepartment = new Department(departmentName);
                        DatabaseFunctions.AddDepartment(newDepartment);
                    }
                    DatabaseFunctions.GetAllDepartments();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill in the empty field.");
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
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions.RemoveDepartment(_departmentToBeEdited);
                DatabaseFunctions.GetAllDepartments();
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
        }
    }
}
