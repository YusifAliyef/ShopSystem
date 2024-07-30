using Microsoft.EntityFrameworkCore;
using ShopSystemTechDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemTechDb.Contexts
{
    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ShopSystemDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> productOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
