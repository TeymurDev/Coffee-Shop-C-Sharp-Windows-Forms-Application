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
    
    public partial class UpdateProduct : Form
    {
        private readonly SeeYouLatteEntities _context;
        Product selectedProduct;
        public UpdateProduct()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillCombo();
        }

        private void FillCombo() {

            var combo = _context.Categories.Where(em => em.Active == true);

            cmbCategory.Items.AddRange(combo.ToArray());
        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgvProducts.Rows[e.RowIndex].Cells[0].Value;
            selectedProduct = _context.Products.FirstOrDefault(c => c.Id == id);
            txtName.Text = selectedProduct.Name;
            nupPrice.Value = Convert.ToDecimal(selectedProduct.Price);
            cmbCategory.SelectedItem = selectedProduct.Category.Name;

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (nupPrice.Value > 0 && txtName.Text != "" && cmbCategory.SelectedItem != null)
            {
                selectedProduct.Name = txtName.Text.Trim();
                selectedProduct.Price = nupPrice.Value;

                string productName = cmbCategory.SelectedItem.ToString();
                Category categoryofp = _context.Categories.FirstOrDefault(c => c.Name == productName);

                selectedProduct.CategoryId = categoryofp.Id;
                _context.SaveChanges();
                FillProducts();
            }
            else
            {
                ShowMessage("Please fill all inputs");
                return;
            }

        }

        private void FillProducts() {

            var activeDetection = _context.Products.Where(em => em.IsActive == true);
            dgvProducts.DataSource = activeDetection.Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Category = p.Category.Name, IsActive = p.IsActive }).ToList();
            dgvProducts.Columns["Id"].Visible = false;

        }
    }
}
