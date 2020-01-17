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
    public partial class UpdateCategory : Form
    {
        private readonly SeeYouLatteEntities _context;
        Category updatedCategory;
        public UpdateCategory()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            FillComboCate();
        }


        private void FillComboCate()
        {
            var combo = _context.Categories.Where(em => em.Active == true);

            cmbUpdatedCategory.Items.AddRange(combo.ToArray());
        }

        private void cmbUpdatedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatedCategory = cmbUpdatedCategory.SelectedItem as Category;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtUpdateCategory.Text.Trim();

            if (name == "" || updatedCategory == null)
            {
                ShowMessage("Please fill all inputs");
                return;
            }
            updatedCategory.Name = name;
            _context.SaveChanges();
            FillComboCate();

            Close();
        }
    }
}
