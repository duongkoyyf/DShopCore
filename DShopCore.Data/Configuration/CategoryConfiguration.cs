using DShopCore.Data.Entities;
using DShopCore.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Catergories");
                
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
