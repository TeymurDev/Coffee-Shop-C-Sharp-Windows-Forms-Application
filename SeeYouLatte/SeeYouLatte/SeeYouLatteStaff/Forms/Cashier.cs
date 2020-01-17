using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeYouLatteStaff.Model;

namespace SeeYouLatteStaff.Forms
{
    public partial class Cashier : Form
    {
        private readonly SeeYouLatteEntities _context;
        List<OrderDetail> _orderdetails;
        private readonly Employee currentEmployee;
        public Cashier(Employee employee)
        {
            InitializeComponent();
            _context = new SeeYouLatteEntities();
            _orderdetails = new List<OrderDetail>();
            currentEmployee = employee;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduct.Items.Clear();
            var category = cmbCategory.SelectedItem as Category;
            //var products = _context.Products.Where(s => s.CategoryId == category.Id);
            cmbProduct.Items.AddRange(category.Products.ToArray());

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            var combo = _context.Categories.Where(em => em.Active == true);

            cmbCategory.Items.AddRange(combo.ToArray());
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupPrice.Value = 0;
            var product = cmbProduct.SelectedItem as Product;
            nupPrice.Value = (decimal)product.Price;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (nupCount.Value > 0 && cmbCategory.SelectedItem !=null && cmbProduct.SelectedItem != null)
            {
                var product = cmbProduct.SelectedItem as Product;
                var count = nupCount.Value;
                var price = nupPrice.Value;

                _orderdetails.Add(new OrderDetail { Product = product, Count = (int)count, Price = price });
                UpdateItemButtons();
            }
            else
            {
                MessageBox.Show("Please select the products");
            }
        }

        private void UpdateItemButtons()
        {
            decimal total = 0;
            flpCashier.Controls.Clear();


            foreach (var item in _orderdetails)
            {
                Button button = new Button();
                button.Click += SelfButtonDelete;
                button.Text = $"{item.Product.Name} - {item.Count}";
                button.BackColor = Color.Tomato;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = SystemColors.ControlLightLight;
                button.Name = "btnLogin";
                button.Size = new Size(150, 50);
                button.UseVisualStyleBackColor = false;
                flpCashier.Controls.Add(button);

                total += (decimal)item.Count * Convert.ToDecimal(item.Price);

            }
            nudTotalPrice.Value = Convert.ToDecimal(total);
            flpCashier.Visible = true;
        }

        private void SelfButtonDelete(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null)
            {
                nudTotalPrice.Value = 0;
                _orderdetails.Clear();
                button.Dispose();
            }
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {

            if (_orderdetails.Count != 0)
            {
                Order order = new Order()
                {
                    Date = DateTime.Now,
                    Status = false,
                    EmployeeId = currentEmployee.Id
                };
                _context.Orders.Add(order);
                _context.SaveChanges();


                foreach (var item in _orderdetails)
                {
                    item.OrderId = order.Id;
                    _context.OrderDetails.Add(item);

                }
                _context.SaveChanges();
                flpCashier.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Please add products to the order");
            }

        }
    }
}


