using SeeYouLatteStaff.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeeYouLatteStaff.Utilities.Utilities;


namespace SeeYouLatteStaff.Forms
{
    public partial class LoginNewPass : Form
    {
        private readonly SeeYouLatteEntities _context;
        public LoginNewPass()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (username == "" || newPassword == "" || confirmPassword == "")
            {
                ShowMessage("Password or Username cannot be empty");
                return;
            }

            var employee = _context.Employees.FirstOrDefault(em => em.Username == username);

            if (employee == null)
            {
                ShowMessage("Wrong Information");
                return;
            }

            if (confirmPassword != newPassword)
            {
                ShowMessage("Passwords dont match");
                return;
            }

            employee.Password = HashPassword(newPassword);
            employee.IsFirstTime = false;
            MessageBox.Show("Your password is successfully changed");
            _context.SaveChanges();
            if (employee.Role.Name == "Barista")
            {
                MessageBox.Show("Hello Barista");
                (new Barista()).ShowDialog();
            }
            else if (employee.Role.Name == "Cashier")
            {
                MessageBox.Show("Hello Cashier");
                (new Cashier(employee)).ShowDialog();
                
            }
        }
    }
    }

