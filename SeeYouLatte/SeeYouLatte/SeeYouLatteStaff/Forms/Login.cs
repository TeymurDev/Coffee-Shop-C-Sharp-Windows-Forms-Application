using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeYouLatteStaff.Model;
using static SeeYouLatteStaff.Utilities.Utilities;

namespace SeeYouLatteStaff.Forms
{
    public partial class Login : Form
    {
        private readonly SeeYouLatteEntities _context;
        public Login()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
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

            if (!CheckPassword(password, employee.Password))
            {
                ShowMessage("Password or Username is wrong");
                return;
            }

            if (employee.IsFirstTime == true)
            {
                (new LoginNewPass()).ShowDialog();
            }
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
