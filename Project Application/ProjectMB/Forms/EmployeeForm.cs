using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class EmployeeForm : Form
    {
        private bool _edit = false;
        private User _userToBeEdited;
        Color[] colors = {Color.Red, Color.LightBlue, Color.Orange, Color.Black};   


        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        #region Constructors
        public EmployeeForm()
        {
            InitializeComponent();
            this.removeBtn.Enabled = false;
            _edit = false;
            loadDepartments();
        }
        public EmployeeForm(User user)
        {
            InitializeComponent();
            loadDepartments();
            _userToBeEdited = user;
            this.firstNameTb.Text = user.FirstName;
            this.lastNameTb.Text = user.LastName;
            this.emailTb.Text = user.Email;
            this.salaryTb.Text = user.Salary.ToString("C2", CultureInfo.CurrentCulture);
            this.departmentCb.SelectedIndex = departmentCb.Items.IndexOf(user.UserDepartment.Name);
            this.roleCb.SelectedIndex = roleCb.Items.IndexOf(user.Position.ToString());
            //this.shiftCb.SelectedIndex = shiftCb.Items.IndexOf(user.ShiftTypeU.ToString());
            mondayCbx.BackColor = colors[user.WorkingDays[0]];
            tuesdayCbx.BackColor = colors[user.WorkingDays[1]];
            wednesdayCbx.BackColor = colors[user.WorkingDays[2]];
            thursdayCbx.BackColor = colors[user.WorkingDays[3]];
            fridayCbx.BackColor = colors[user.WorkingDays[4]];
            saturdayCbx.BackColor = colors[user.WorkingDays[5]];
            sundayCbx.BackColor = colors[user.WorkingDays[6]];

            _edit = true;
            titleLbl.Text = "Edit Employee";
        }
        #endregion
        private void loadDepartments()
        {
            departmentCb.Items.Clear();
            departmentCb.Items.Add("Department");
            foreach (var item in Departments.departments)
            {
                departmentCb.Items.Add(item.Name);
            }

        }
        #region CRUD
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Users.RemoveUser(_userToBeEdited);
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
                    !string.IsNullOrWhiteSpace(emailTb.Text) && !string.IsNullOrWhiteSpace(salaryTb.Text))
                {
                    if (departmentCb.SelectedIndex > 0 && roleCb.SelectedIndex > 0)
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
                            double salary = double.Parse(salaryStr.Trim());
                            Department department = Departments.DepartmentByName(departmentCb.SelectedItem.ToString());
                            PersonPosition position = (PersonPosition)Enum.Parse(typeof(PersonPosition), roleCb.Text, true);
                            if ((position == PersonPosition.Manager && Users.admin) || (position != PersonPosition.Manager))
                            {
                                byte[] _days = new byte[7];
                                _days[0] = (byte) Array.IndexOf(colors, mondayCbx.BackColor);
                                _days[1] = (byte) Array.IndexOf(colors, tuesdayCbx.BackColor);
                                _days[2] = (byte) Array.IndexOf(colors, wednesdayCbx.BackColor);
                                _days[3] = (byte) Array.IndexOf(colors, thursdayCbx.BackColor);
                                _days[4] = (byte) Array.IndexOf(colors, fridayCbx.BackColor);
                                _days[5] = (byte) Array.IndexOf(colors, saturdayCbx.BackColor);
                                _days[6] = (byte) Array.IndexOf(colors, sundayCbx.BackColor);

                                if (_edit)
                                {
                                    _userToBeEdited.FirstName = fn;
                                    _userToBeEdited.LastName = ln;
                                    _userToBeEdited.Email = email;
                                    _userToBeEdited.Position = position;
                                    _userToBeEdited.Salary = salary;
                                    _userToBeEdited.WorkingDays = _days;
                                    _userToBeEdited.UserDepartment = department;
                                    Users.UpdateUser(_userToBeEdited);
                                }
                                else
                                {
                                    if (position == PersonPosition.Manager)
                                    {
                                        Users.AddUser(new User(fn, ln, email, position, salary, _days, department), true);
                                    }
                                    else
                                    {
                                         Users.AddUser(new User(fn, ln, email, position, salary, _days, department));
                                    }
                                }
                                DatabaseFunctions.GetAllUsers();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Managers can be added just by admin profile!", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            }
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
        #endregion
        #region Design
        private void mondayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, mondayCbx.BackColor);
            if (index == 3) index = -1;
            mondayCbx.BackColor = colors[index + 1];
        }

        private void tuesdayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, tuesdayCbx.BackColor);
            if (index == 3) index = -1;
            tuesdayCbx.BackColor = colors[index + 1];
        }

        private void wednesdayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, wednesdayCbx.BackColor);
            if (index == 3) index = -1;
            wednesdayCbx.BackColor = colors[index + 1];
        }

        private void thursdayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, thursdayCbx.BackColor);
            if (index == 3) index = -1;
            thursdayCbx.BackColor = colors[index + 1];
        }

        private void fridayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, fridayCbx.BackColor);
            if (index == 3) index = -1;
            fridayCbx.BackColor = colors[index + 1];
        }

        private void saturdayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, saturdayCbx.BackColor);
            if (index == 3) index = -1;
            saturdayCbx.BackColor = colors[index + 1];
        }

        private void sundayCbx_CheckedChanged(object sender, EventArgs e)
        {
            int index = Array.IndexOf(colors, sundayCbx.BackColor);
            if (index == 3) index = -1;
            sundayCbx.BackColor = colors[index + 1];
        }
        private void firstNameTb_Click(object sender, EventArgs e)
        {
            if (firstNameTb.Text == "First Name")
            {
                firstNameTb.Text = "";
            }

            firstNamePnl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void firstNameTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTb.Text))
            {
                firstNameTb.Text = "First Name";
            }

            firstNamePnl.BackColor = Color.FromArgb(125, 249, 255);
        }

        private void lastNameTb_Click(object sender, EventArgs e)
        {
            if (lastNameTb.Text == "Last Name")
            {
                lastNameTb.Text = "";
            }

            lastNamePnl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void lastNameTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTb.Text))
            {
                lastNameTb.Text = "Last Name";
            }

            lastNamePnl.BackColor = Color.FromArgb(125, 249, 255);
        }

        private void emailTb_Click(object sender, EventArgs e)
        {
            if (emailTb.Text == "Email")
            {
                emailTb.Text = "";
            }

            emailPnl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTb.Text))
            {
                emailTb.Text = "Email";
            }

            emailPnl.BackColor = Color.FromArgb(125, 249, 255);
        }

        private void salaryTb_Click(object sender, EventArgs e)
        {
            if (salaryTb.Text == "Salary")
            {
                salaryTb.Text = "";
            }

            salaryPnl.BackColor = Color.FromArgb(218, 112, 214);
        }

        private void salaryTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(salaryTb.Text))
            {
                salaryTb.Text = "Salary";
            }

            salaryPnl.BackColor = Color.FromArgb(125, 249, 255);
        }
        #endregion

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void legendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red is for no shift\nLight Blue is for day shift\nOrange is for half-day shift\nBlack is for night shift");
        }
    }
}
