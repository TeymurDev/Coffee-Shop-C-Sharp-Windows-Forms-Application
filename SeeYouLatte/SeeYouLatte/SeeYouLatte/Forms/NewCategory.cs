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
    public partial class NewCategory : Form
    {
        private readonly SeeYouLatteEntities _context;

        public NewCategory()
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategory.Text.Trim();


            if (name == "")
            {
                ShowMessage("Category can not be empty");
                return;
            }
            Category newcategory = new Category
            {
                Name = name,
                Active = true
            };

            _context.Categories.Add(newcategory);
            _context.SaveChanges();

            Close();
        }
    }
}
