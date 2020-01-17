using SeeYouLatte.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeeYouLatte.Utilities.Utilities;



namespace SeeYouLatte.Forms
{
    public partial class DeleteEmployee : Form
    {
        private readonly SeeYouLatteEntities _context;
        Employee selectedEmployee;
        public DeleteEmployee()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            FillEmployeees();
        }

        private void FillEmployeees()
        {
            var datadgv = _context.Employees.Where(em => em.ActiveEmp == true);
            dgvEmployees.DataSource = datadgv.Select(p => new { Id = p.Id, Firstname = p.Firstname, Lastname = p.Lastname,
                Username = p.Username, Password = p.Password, IsFirstTime = p.IsFirstTime, RoleId = p.Role, ActiveEmp = p.ActiveEmp }).ToList();
        }

        private void dgvEmployees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvEmployees.Rows[e.RowIndex].Cells[0].Value;
            selectedEmployee = _context.Employees.FirstOrDefault(c => c.Id == id);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                selectedEmployee.ActiveEmp = false;
                _context.SaveChanges();
                FillEmployeees();
                MessageBox.Show("Employee Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                ShowMessage("Please select employee for deletion");

            }
        }
    }
}
