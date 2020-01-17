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
    public partial class DeleteCategory : Form
    {
        private readonly SeeYouLatteEntities _context;
        Category deletedcategory;
        public DeleteCategory()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {
            FillComboCategories();
        }

        private void FillComboCategories() {

            var combo = _context.Categories.Where(em => em.Active == true);

            cmbCategoriesforDeletion.Items.AddRange(combo.ToArray());
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

            if (cmbCategoriesforDeletion.SelectedItem == null)
            {
                ShowMessage("Category can not be empty");
                return;
            }

            deletedcategory.Active = false;
            _context.SaveChanges();
            FillComboCategories();
            Close(); 
        }

        private void cmbCategoriesforDeletion_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletedcategory = cmbCategoriesforDeletion.SelectedItem as Category;
        }

      
    }
}
