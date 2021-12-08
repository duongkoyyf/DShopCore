using DShopCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DShopCore.Data.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new {x.OrderId,x.ProductId });
            builder.HasOne(x => x.Order).WithMany(od => od.OrderDetails).HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Product).WithMany(od => od.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
