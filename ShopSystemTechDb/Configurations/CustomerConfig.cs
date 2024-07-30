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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(50)");
            builder.Property(x => x.LastName)
               .IsRequired()
               .HasColumnType("nvarchar(50)");


        }
    }
}
