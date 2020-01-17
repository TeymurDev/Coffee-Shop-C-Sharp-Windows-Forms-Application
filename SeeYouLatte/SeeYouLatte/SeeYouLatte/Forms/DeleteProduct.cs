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
    public partial class DeleteProduct : Form
    {
        private readonly SeeYouLatteEntities _context;
        Product selectedProduct;

        public DeleteProduct()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                selectedProduct.IsActive = false;
                _context.SaveChanges();
                FillProducts();
                MessageBox.Show("Product Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                ShowMessage("Please select product for deletion");

            }
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            FillProducts();
        }

        public void FillProducts()
        {
            var datadgv = _context.Products.Where(em => em.IsActive == true);
                dgvProducts.DataSource = datadgv.Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, IsActive = p.IsActive }).ToList();
        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvProducts.Rows[e.RowIndex].Cells[0].Value;
            selectedProduct = _context.Products.FirstOrDefault(c => c.Id == id);
        }
    }
}
