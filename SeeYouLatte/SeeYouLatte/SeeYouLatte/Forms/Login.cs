using System;
using System.Windows.Forms;
using System.Linq;
using SeeYouLatte.Model;
using static SeeYouLatte.Utilities.Utilities;

namespace SeeYouLatte.Forms
{
    public partial class Login : Form
    {
        private readonly SeeYouLatteEntities _context;

        public Login()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(username == "" || password == "")
            {
                ShowMessage("Password or username can not be empty");
                return;
            }

            Employee admin = _context.Employees.FirstOrDefault(emp => emp.Username == username);

            if(admin == null)
            {
                ShowMessage("Password or username is wrong");
                return;
            }

            if(!CheckPassword(password, admin.Password))
            {
                ShowMessage("Password or username is wrong");
                return;
            }

            if (admin.Role.Name != "Admin")
            {
                ShowMessage("Unauthorized");
                txtPassword.Text = "";
                return;
            }
            (new Dashboard()).ShowDialog();

         
        }
        
    }
}
