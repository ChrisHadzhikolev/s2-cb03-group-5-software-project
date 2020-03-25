using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class EmployeeForm : Form
    {
        User _usrToBeEdited;
        private bool[] _days = {false, false, false, false, false, false, false};
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
            this.shiftCb.SelectedValue = _usrToBeEdited.ShiftTypeU.ToString();
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
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("User is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(firstNameTb.Text) && !string.IsNullOrWhiteSpace(lastNameTb.Text) &&
                    !string.IsNullOrWhiteSpace(firstNameTb.Text) && !string.IsNullOrWhiteSpace(salaryTb.Text))
                {
                    if (shiftCb.SelectedIndex > -1)
                    {
                        const string emailPattern =
                                            "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
                        Regex regex = new Regex(emailPattern);
                        if (regex.IsMatch(emailTb.Text))
                        {
                            string fn = firstNameTb.Text;
                            string ln = lastNameTb.Text;
                            string email = emailTb.Text;
                            string salaryStr = Regex.Replace(salaryTb.Text, "€", "");
                            double salary =  double.Parse(salaryStr.Trim());
                            ShiftType type = (ShiftType) Enum.Parse(typeof(ShiftType), shiftCb.Text, true);

                            if (_edit)
                            {
                                _usrToBeEdited.FirstName = fn;
                                _usrToBeEdited.LastName = ln;
                                _usrToBeEdited.Email = email;
                                _usrToBeEdited.Salary = salary;
                                _usrToBeEdited.WorkingDays = _days;
                                _usrToBeEdited.Position = PersonPosition.EMPLOYEE;
                                _usrToBeEdited.Department = Users.Department;
                                _usrToBeEdited.ShiftTypeU = type;
                                DatabaseFunctions.UpdateUser(_usrToBeEdited);
                            }
                            else
                            {
                                _usrToBeEdited = new User(fn, ln, email, PersonPosition.EMPLOYEE, salary, type, _days,
                                    Users.Department);
                                DatabaseFunctions.AddUser(_usrToBeEdited);
                            }
                            DatabaseFunctions.GetEmployeesByDepartment(Users.Department);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please, select a valid Email!", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);   
                        }
                       
                    } 
                    else
                    {
                        MessageBox.Show("Choose valid shift!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty fields!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Salary must be numeric!");
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("User is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UsernameErrorException)
            {
                MessageBox.Show("Error occured, when tried to generate username, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error loading resources, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
