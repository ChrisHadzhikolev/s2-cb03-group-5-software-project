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
    public partial class EmployeeForm : Form
    {
        //Users users = new Users();
        ListBox listBox;
        string name;
        public EmployeeForm()
        {
            InitializeComponent();

        }
        public EmployeeForm(string name, ListBox listbox)
        {
            InitializeComponent();
            this.name = name;
            this.listBox = listbox;

        }
        
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
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
            bool[] days = checkboxDialog.SelectedValues();
            foreach (var item in days)
            {
                if (item) MessageBox.Show("smth");
            }
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
           
                if (emailTb.TextLength > 0 && nameTb.TextLength > 0 && quantityTb.TextLength > 0)
                {

                if (shiftCb.SelectedIndex>-1 && typeCb.SelectedIndex>-1)
                {
                    if (nameTb.Text == name) //check if the name put in the textbox is in the listbox 
                    {
                        listBox.Items.Remove(name);
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty fields.");
                }
                } else
            {
                MessageBox.Show("Fill in the empty fields.");
            }
        }
    }
}
