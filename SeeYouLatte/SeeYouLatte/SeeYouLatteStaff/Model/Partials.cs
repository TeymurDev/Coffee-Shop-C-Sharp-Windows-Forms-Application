using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeYouLatteStaff.Model
{
    public partial class Category
    {

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Product
    {

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class OrderDetail
    {

        public override string ToString()
        {
            return $"Product: {Product.Name} - Quantity: {Count} - Price: {Price}";
        }
    }
}
