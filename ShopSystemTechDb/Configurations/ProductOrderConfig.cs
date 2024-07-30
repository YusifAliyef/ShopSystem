using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopSystemTechDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemTechDb.Configurations
{
    public class ProductOrderConfig : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductOrder)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Order)
                .WithMany(x => x.ProductOrder)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
