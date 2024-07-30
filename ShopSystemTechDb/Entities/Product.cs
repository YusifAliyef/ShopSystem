using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemTechDb.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public ICollection<ProductOrder> ProductOrder{ get; set;}
    }
}
