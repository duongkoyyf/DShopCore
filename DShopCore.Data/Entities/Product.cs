using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.Entities
{
    public class Product
    {
        public int  Id { set; get; }

        public decimal   Price { set; get; }

        public decimal OriginnalPrice { set; get; }

        public int   Stock { set; get; }

        public int   ViewCount { set; get; }

        public DateTime   DataCreate { set; get; }

        public string SeoAlias { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }

        public List<OrderDetail> OrderDetails { set; get; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
