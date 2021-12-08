using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { set; get; }

        public Product Product { set; get; }

        public int CategoryId { set; get; }

        public Category Category { set; get; }
    }
}
