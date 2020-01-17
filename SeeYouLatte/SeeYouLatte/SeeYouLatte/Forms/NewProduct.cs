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
    public partial class NewProduct : Form
    {
        private readonly SeeYouLatteEntities _context;
        public NewProduct()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void FillCombo()
        {

            //cmbCategory.Items.AddRange(_context.Categories.ToArray());
            var combo = _context.Categories.Where(em => em.Active == true);

            cmbCategory.Items.AddRange(combo.ToArray());
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if (nupPrice.Value > 0 && txtName.Text != "" && cmbCategory.SelectedItem != null)
            {
                var pname = txtName.Text.Trim();
                var pprice = nupPrice.Value;
                var pcategory = cmbCategory.SelectedItem as Category;

                Product product = new Product
                {
                    Name = pname,
                    Price = pprice,
                    CategoryId = pcategory.Id,
                    IsActive = true
                };
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            else
            {
                ShowMessage("Please fill all inputs");
                return;
            }


            Close();
        }
    }
}
