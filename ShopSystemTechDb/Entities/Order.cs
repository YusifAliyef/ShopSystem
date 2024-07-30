using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemTechDb.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  
        public ICollection<ProductOrder> ProductOrder { get; set; }


    }
}
