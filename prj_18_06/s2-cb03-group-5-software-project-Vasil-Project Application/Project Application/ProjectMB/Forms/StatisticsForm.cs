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
using System.Runtime.InteropServices;

namespace ProjectMB
{
    public partial class StatisticsForm : Form
    {

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void btnEmployeeStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.Items.Clear();
            if(cbEmployeeDepartment.SelectedIndex > -1)
            {
                string departmentName = cbEmployeeDepartment.SelectedItem.ToString();
                double avgSalary = 0;
                string favouriteShift = "";

                int day = 0;
                int halfDay = 0;
                int night = 0;

                DatabaseFunctions.GetAllUsers();
                foreach (User user in Users.users.ToList())
                {
                    if (user.Position != PersonPosition.Employee)
                    {
                        Users.users.Remove(user);
                    }
                }
                int employees = 0;
                
                foreach (User user in Users.users)
                {
                    if (user.UserDepartment.Name == departmentName)
                    {
                        avgSalary += user.Salary;
                        employees++;

                        Dictionary<string, int> shiftsForUser = DatabaseFunctions.GetShiftsForUser(user);

                        foreach (var VARIABLE in shiftsForUser.Keys)
                        {
                            if (shiftsForUser[VARIABLE] == 1)
                            {
                                day++;
                            }
                            else if (shiftsForUser[VARIABLE] == 2)
                            {
                                halfDay++;
                            }
                            else if (shiftsForUser[VARIABLE] == 3)
                            {
                                night++;
                            }
                        }
                        shiftsForUser.Clear();
                    }
                }

                if (Math.Max(Math.Max(day, halfDay), night) == day)
                {
                    favouriteShift = "Day";
                }
                else if (Math.Max(Math.Max(day, halfDay), night) == halfDay)
                {
                    favouriteShift = "HalfDay";
                }
                else if (Math.Max(Math.Max(day, halfDay), night) == night)
                {
                    favouriteShift = "Night";
                }
                lbStatistics.Items.Add($"The average salary for the department {departmentName} is: {(avgSalary / employees).ToString("C2", CultureInfo.CurrentCulture)}");
                lbStatistics.Items.Add($"The favourite shift of the employees for the {departmentName} department is: {favouriteShift}");
            }
            else
            {
                double avgSalary = 0;
                string favouriteShift = "";

                int day = 0;
                int halfDay = 0;
                int night = 0;
                DatabaseFunctions.GetAllUsers();
                foreach (User user in Users.users.ToList())
                {
                    if (user.Position != PersonPosition.Employee)
                    {
                        Users.users.Remove(user);
                    }
                }
                int employees = 0;
                foreach (User user in Users.users)
                {
                    avgSalary += user.Salary; 
                    employees++;

                    Dictionary<string, int> shiftsForUser = DatabaseFunctions.GetShiftsForUser(user);

                    foreach (var VARIABLE in shiftsForUser.Keys)
                    {
                        if (shiftsForUser[VARIABLE] == 1)
                        {
                            day++;
                        }
                        else if (shiftsForUser[VARIABLE] == 2)
                        {
                            halfDay++;
                        }
                        else if (shiftsForUser[VARIABLE] == 3)
                        {
                            night++;
                        }
                    }
                    shiftsForUser.Clear();
                }
                if (Math.Max(Math.Max(day, halfDay), night) == day)
                {
                    favouriteShift = "Day";
                }
                else if (Math.Max(Math.Max(day, halfDay), night) == halfDay)
                {
                    favouriteShift = "HalfDay";
                }
                else if (Math.Max(Math.Max(day, halfDay), night) == night)
                {
                    favouriteShift = "Night";
                }
                lbStatistics.Items.Add($"The average salary for all the employees is: {(avgSalary / employees).ToString("C2", CultureInfo.CurrentCulture)}");
                lbStatistics.Items.Add($"The most requested shift of all the employees is: {favouriteShift}");
            }
        }
        private void btnGetProductStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.Items.Clear();
            if (cbProductCategories.SelectedIndex > -1)
            {
                int categoryName = cbProductCategories.SelectedIndex;
                double avgPrice = 0;
                int productsInCategory = 0;
                int restocks = 0;

                //int[] categories = new int[9];
                //DatabaseFunctions.GetAllProductsByCategory((ProductCategory)categoryName);
                DatabaseFunctions.GetAllProducts();
                Product mostRestocked = new Product("Bom", ProductCategory.COMPUTER, 2.2, 8, false);
                foreach (Product product in Products.products)
                {
                    if (product.Category == (ProductCategory)categoryName)
                    {
                        if (product.Quantity > restocks)
                        {
                            mostRestocked.Name = product.Name;
                            mostRestocked.Category = product.Category;
                            mostRestocked.Price = product.Price;
                            mostRestocked.Quantity = product.Quantity;
                            restocks = product.Quantity;
                        }
                        productsInCategory++;
                        avgPrice += product.Price;
                        //lbStatistics.Items.Add(product.ToString());
                    }
                }
                if(productsInCategory == 0)
                {
                    lbStatistics.Items.Add($"There are {productsInCategory} products in this category.");
                }
                else
                {
                    lbStatistics.Items.Add($"There are {productsInCategory} products in this category with average price of {(avgPrice / productsInCategory).ToString("C2", CultureInfo.CurrentCulture)}");
                    lbStatistics.Items.Add($"The most restocked product is: {mostRestocked.Name} Price: {mostRestocked.Price} Quantity: {mostRestocked.Quantity}");
                }
            }
            else
            {
                double avgPrice = 0;
                double mostExpensive = 0; 
                Product mostExpensiveP = new Product("Test", ProductCategory.COMPUTER, 2.2, 8, false);
                DatabaseFunctions.GetAllProducts();

                foreach (Product product in Products.products)
                {
                    if (product.Price > mostExpensive)
                    {
                        mostExpensiveP.Name = product.Name;
                        mostExpensiveP.Category = product.Category;
                        mostExpensiveP.Price = product.Price;
                        mostExpensiveP.Quantity = product.Quantity;

                        mostExpensive = product.Price;
                    }
                    avgPrice += product.Price;
                }
                lbStatistics.Items.Add($"There are {Products.products.Count} products in total. The average price is {(avgPrice / Products.products.Count).ToString("C2", CultureInfo.CurrentCulture)}");
                lbStatistics.Items.Add($"The most expensive product is: {mostExpensiveP.Name} Price: {mostExpensiveP.Price} Quantity: {mostExpensiveP.Quantity}");
            }
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.btnEmployeeStatistics.BackColor = Color.FromArgb(5, 179, 245);
            this.btnEmployeeStatistics.FlatStyle = FlatStyle.Flat;
            this.btnGetProductStatistics.BackColor = Color.FromArgb(5, 179, 245);
            this.btnGetProductStatistics.FlatStyle = FlatStyle.Flat;
            //this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            //this.searchBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }
    }
} 
