using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeYouLatte.Model
{
    public partial class Role
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Category
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
