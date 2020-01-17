using System;
using System.Windows.Forms;
using System.Linq;
using SeeYouLatte.Model;
using static SeeYouLatte.Utilities.Utilities;

namespace SeeYouLatte.Forms
{
    public partial class NewEmployee : Form
    {
        private readonly SeeYouLatteEntities _context;
        public NewEmployee()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            FillRolesCombo();
        }

        private void FillRolesCombo()
        {
            cmbRoles.Items.AddRange(_context.Roles.ToArray());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text.Trim();
            string lname = txtLastname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            Role role = cmbRoles.SelectedItem as Role;

            if(fname == "" || username == "" || password == "")
            {
                ShowMessage("Firstname or username or password is empty");
                return;
            }

            if(_context.Employees.Any(emp => emp.Username == username))
            {
                ShowMessage("Username exists");
                return;
            }

            if(role == null)
            {
                ShowMessage("Role should be selected");
                return;
            }

            //username doesnt't exist and role selected, so create new employee
            Employee employee = new Employee
            {
                Firstname = fname,
                Lastname = lname,
                Username = username,
                Password = HashPassword(password),
                RoleId = role.Id,
                IsFirstTime = true,
                ActiveEmp = true
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            ShowMessage("User successfully selected", error: false);

            Close();
        }


    }
}
