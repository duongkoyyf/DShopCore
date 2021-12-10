using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public decimal Price { set; get; }

        public decimal OriginnalPrice { set; get; }

        public int Stock { set; get; }

        public int ViewCount { set; get; }

        public DateTime DataCreate { set; get; }

        public string SeoAlias { set; get; }

        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }


        public string LanguageId { set; get; }
    }
}
