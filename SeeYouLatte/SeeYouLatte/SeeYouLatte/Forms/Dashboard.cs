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

namespace SeeYouLatte.Forms
{
    public partial class Dashboard : Form
    {
        private readonly SeeYouLatteEntities _context;
        public Dashboard()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void CreateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            (new NewEmployee()).ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new NewCategory()).ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new DeleteCategory()).ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new UpdateCategory()).ShowDialog();
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            (new NewProduct()).ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new DeleteProduct()).ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new UpdateProduct()).ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            (new DeleteEmployee()).ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            decimal sum= 0;

            var q = (from or in _context.Orders
                     join od in _context.OrderDetails on or.Id equals od.OrderId
                     where or.Date.Value.Day == dtpDashboard.Value.Day
                     select new
                     {
                         od.Count,
                         od.Price,
                         or.Date,
                     }).ToArray();

            dgvDashboard.DataSource = q;
            foreach (var item in q)
            {
                sum += (decimal)item.Count * (decimal)item.Price;
         
            }

            nudDashboard.Value = sum;
        }
    }
}
