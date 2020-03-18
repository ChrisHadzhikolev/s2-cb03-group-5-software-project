using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class EmployeeForm : Form
    {
        User _usrToBeEdited;
        private bool[] _days;
        private bool _edit = false;
        public EmployeeForm()
        {
            InitializeComponent();
            this.removeBtn.Enabled = false;
            _edit = false;
        }
        public EmployeeForm(User user)
        {
            InitializeComponent();
            _usrToBeEdited = user;
            this.firstNameTb.Text = _usrToBeEdited.FirstName;
            this.lastNameTb.Text = _usrToBeEdited.LastName;
            this.emailTb.Text = _usrToBeEdited.Email;
            this.salaryTb.Text = _usrToBeEdited.Salary.ToString("C2", CultureInfo.CurrentCulture);
            this.firstNameTb.Text = _usrToBeEdited.FirstName;
            this.shiftCb.Text = _usrToBeEdited.ShiftTypeU.ToString();
            _edit = true;
        }
       
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.cancelBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.cancelBtn.FlatStyle = FlatStyle.Flat;
            this.confirmBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.confirmBtn.FlatStyle = FlatStyle.Flat;
            this.daysBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.daysBtn.FlatStyle = FlatStyle.Flat;
            this.removeBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.removeBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void daysBtn_Click(object sender, EventArgs e)
        {
            CheckboxDialog checkboxDialog = new CheckboxDialog();
            checkboxDialog.ShowDialog("Select Days:");
            do
            {
                System.Threading.Thread.Sleep(1000);
            } while (checkboxDialog.FormOpened);
            _days = checkboxDialog.SelectedValues();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions.RemoveUser(_usrToBeEdited);
                DatabaseFunctions.GetEmployeesByDepartment(Users.Department);
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Error", "Connection unsuccessful, please restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Error", "User is non-existent, please restart", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        if (!string.IsNullOrWhiteSpace(firstNameTb.Text) && !string.IsNullOrWhiteSpace(lastNameTb.Text) && !string.IsNullOrWhiteSpace(firstNameTb.Text) && !string.IsNullOrWhiteSpace(salaryTb.Text))
        //        {
        //            MessageBox.Show("habibi");
        //            if (shiftCb.SelectedIndex > -1)
        //            {
        //                MessageBox.Show("spish");
        //                //string fn = firstNameTb.Text;
        //                //string fn = firstNameTb.Text;
        //                //string fn = firstNameTb.Text;
        //                //string fn = firstNameTb.Text;
        //                //string fn = firstNameTb.Text;
                        
        //                if (_edit)
        //                {
        //                    _usrToBeEdited.FirstName = fn;
        //                    _usrToBeEdited.LastName = lastNameTb.Text;
        //                    _usrToBeEdited.Email = emailTb.Text;
        //                    _usrToBeEdited.Salary = int.Parse(salaryTb.Text);
        //                    _usrToBeEdited.WorkingDays = _days;
        //                    _usrToBeEdited.Position = PersonPosition.EMPLOYEE;
        //                    _usrToBeEdited.Department = Users.Department;
        //                    _usrToBeEdited.ShiftTypeU = (ShiftType) Enum.Parse(typeof(ShiftType), shiftCb.Text, true);
        //                    //_usrToBeEdited.Username = _usrToBeEdited.GenerateUsername();
        //                    MessageBox.Show("li");
        //                    DatabaseFunctions.UpdateUser(_usrToBeEdited);
        //                    MessageBox.Show("dobre");
        //                }
        //                else
        //                {
        //                    _usrToBeEdited = new User(firstNameTb.Text);
        //                   DatabaseFunctions.AddUser(_usrToBeEdited);
        //                }
        //                DatabaseFunctions.GetEmployeesByDepartment(Users.Department);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Choose valid shift!");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Fill in the empty fields!");
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("Salary must be numeric!");
        //    }
        //    catch (NoConnectionException)
        //    {
        //        MessageBox.Show("Error", "Connection unsuccessful, please restart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (NotExistingException)
        //    {
        //        MessageBox.Show("Error", "User is non-existent, please restart", MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
           
     }
    }
}
