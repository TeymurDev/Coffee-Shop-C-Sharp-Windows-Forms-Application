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

namespace SeeYouLatteStaff.Forms
{
    public partial class Barista : Form
    {
        private readonly SeeYouLatteEntities _context;
        Order selectedOrder;
        public Barista()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void Barista_Load(object sender, EventArgs e)
        {
            FillBarristaList();
        }

        private void FillBarristaList()
        {
            var statusDetection = _context.Orders.Where(em => em.Status == false);
            dgvBarista.DataSource = statusDetection.Select(p => new { Id = p.Id, Date = p.Date, Status = p.Status, Employee = p.Employee.Firstname }).ToList();
        }

        private void dgvBarista_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvBarista.Rows[e.RowIndex].Cells[0].Value;
            selectedOrder = _context.Orders.FirstOrDefault(c => c.Id == id);

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (selectedOrder != null)
            {
                selectedOrder.Status = true;
                _context.SaveChanges();
                FillBarristaList();
                MessageBox.Show("Product is Ready", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select Order from Pending Orders List");
            }

        }

        private void dgvBarista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lsbOrderDetails.Items.Clear();
            int id = (int)dgvBarista.Rows[e.RowIndex].Cells[0].Value;
            var selectedorder = _context.OrderDetails.Where(em => em.OrderId == id);
            lsbOrderDetails.Items.AddRange(selectedorder.ToArray());
        }

    }
}
