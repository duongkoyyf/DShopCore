using DShopCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.EF
{
    public class DShopCoreContext : DbContext
    {
        public DShopCoreContext( DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
