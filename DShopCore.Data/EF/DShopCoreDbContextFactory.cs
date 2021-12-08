using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.EF
{
    public class DShopCoreDbContextFactory : IDesignTimeDbContextFactory<DShopCoreContext>
    {
        public DShopCoreContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DShopCoreDB");

            var optionsBuilder = new DbContextOptionsBuilder<DShopCoreContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DShopCoreContext(optionsBuilder.Options);
        }
    }
}
