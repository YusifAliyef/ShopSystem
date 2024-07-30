
// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using ShopSystemTechDb.Contexts;
using ShopSystemTechDb.Entities;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");


using (ShopContext context = new ShopContext())
{

    //Customer customer = new Customer()
    //{

    //  FirstName="Vali",
    //  LastName="Aliyev"
    //};

    //Order order = new Order()
    //{
    //    OrderNumber=2,
    //    TotalPrice=30,
    //    CustomerId=1


    //};
    //context.Orders.Add(order);


    //Product product = new Product()
    //{
    //    ProductName="Car",
    //    Price=10,
    //    InStock=true
    //};
    //context.Products.Add(product);

    //var customer = context.Customers.Find(1);
    //context.Customers.Remove(customer);

    //context.SaveChanges();  

    //var orders = context.Orders.Find(2);
    //orders.OrderNumber = 10;
    //context.SaveChanges();
    SelectWithEagerLoading(context);

    void SelectWithEagerLoading(ShopContext context)
    {
        var customer = context.Products
            .Include(x=>x.ProductOrder)
            .ThenInclude(x=>x.Order)
            .Select(x=>new
            { 
             
            
            
            
            
            }

             




              ).ToList();
      
    
    
    
    }

}
