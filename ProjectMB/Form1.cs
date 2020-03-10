using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectMB
{
    public partial class MainForm : Form
    {
        Users users;
        DatabaseFunctions databaseFunctions;
        public MainForm()
        {
            InitializeComponent();
            usernameTb.Click += new EventHandler(click_username);
            usernameTb.Leave += new EventHandler(leave_username);
            passwordTb.Click += new EventHandler(click_password);
            passwordTb.Leave += new EventHandler(leave_password);
            databaseFunctions = new DatabaseFunctions();
            databaseFunctions.GetAllUsers();
            users = new Users();
            
        }
        protected void InitializeDesign() 
        {
            //
            //Modifications
            //
            this.ClientSize = new Size((int)(System.Windows.SystemParameters.PrimaryScreenWidth), (int)(System.Windows.SystemParameters.PrimaryScreenHeight));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.loginPnl.SetBounds(0, 0, this.ClientSize.Width, this.ClientSize.Height);

            this.loginComponentsPnl.Size = new System.Drawing.Size(loginPnl.Width / 2, loginPnl.Height / 2);
            this.loginComponentsPnl.Location = new Point((loginPnl.Width - loginComponentsPnl.Width) / 2, (loginPnl.Height - loginComponentsPnl.Height) / 2);
            this.loginComponentsPnl.Anchor = AnchorStyles.None;
            int LCW = loginComponentsPnl.Width;
            int LCH = loginComponentsPnl.Height;

            this.loginBtn.Size = new System.Drawing.Size(usernameTb.Width * 2, loginComponentsPnl.Height/8);
            this.loginBtn.Location = new System.Drawing.Point((loginComponentsPnl.Width-loginBtn.Width)/ 2, (LCH / 3) + usernameTb.Height + 5);

            this.usernameTb.AutoSize = false;
            this.usernameTb.Text = "Username";
            this.usernameTb.BorderStyle = BorderStyle.None;
            this.usernameTb.Controls.Add(usernameLbl);
            usernameTb.SetBounds((LCW - (LCW * 8 / 10)) / 2, 25, LCW * 8 / 10, LCH * 1 / 10);
            usernameLbl.Height = 1;

            this.passwordTb.AutoSize = false;
            this.passwordTb.Text = "Password";
            this.passwordTb.BorderStyle = BorderStyle.None;
            this.passwordTb.Controls.Add(passwordLbl);
            passwordTb.SetBounds((LCW - (LCW * 8 / 10)) / 2, (LCH / 10) + usernameTb.Height + 5, LCW * 8 / 10, LCH * 1 / 10);
            passwordLbl.Height = 1;

            selectionPnl.Visible = false;
            selectionPnl.SetBounds(0, 0, this.ClientSize.Width, this.ClientSize.Height);

            employeesBtn.Size = new Size(selectionPnl.Width/5, selectionPnl.Height/10);
            employeesBtn.Location = new Point((selectionPnl.Width-employeesBtn.Width)/2, (selectionPnl.Height - employeesBtn.Height) / 3);
            productsBtn.Size = new Size(selectionPnl.Width / 5, selectionPnl.Height / 10);
            productsBtn.Location = new Point((selectionPnl.Width - productsBtn.Width)/2, (selectionPnl.Height - productsBtn.Height) * 2 / 3);
            exitBtn.Size = new Size(loginPnl.Width / 15, loginPnl.Height / 20);
            exitBtn.Location = new Point(loginPnl.Width - exitBtn.Width, 10);
        }
        protected void click_username(Object sender, EventArgs e)
        {
            if (usernameTb.Text == "Username")
            {
                usernameTb.Text = "";
            }
            usernameLbl.BackColor = Color.FromArgb(218, 112, 214);
           
        }
        protected void leave_username(Object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(usernameTb.Text))
            {
                usernameTb.Text = "Username";
            }
            usernameLbl.BackColor = Color.FromArgb(125, 249, 255);
        }
        protected void click_password(Object sender, EventArgs e)
        {
            if (passwordTb.Text == "Password")
            {
                passwordTb.Text = "";
            }
            passwordLbl.BackColor = Color.FromArgb(218, 112, 214);

        }
        protected void leave_password(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTb.Text))
            {
                passwordTb.Text = "Password";
            }
            passwordLbl.BackColor = Color.FromArgb(125, 249, 255);
        }
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.Show();
        }
        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {

            User user = users.FindUserByUsername(usernameTb.Text);
            foreach (var item in Users.users)
            {
                MessageBox.Show(item.Username);
            }
            if (user != null)
            {
                if (user.Position == PersonPosition.MANAGER)
                {
                    string pass = databaseFunctions.PasswordByUsername(user.Username);
                    if (pass == passwordTb.Text)
                    {
                        loginPnl.Visible = false;
                        selectionPnl.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password, please try again!");
                    }
                }
                else
                {
                    MessageBox.Show("This Platform is only for managers!");
                }

            }
            else
            {
                MessageBox.Show("No such user, please try again!");
            }
            
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDesign();
        }
    }
}
