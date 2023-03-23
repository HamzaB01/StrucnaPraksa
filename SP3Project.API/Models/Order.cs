using System.Collections.Generic;

namespace SP3Project.API.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
         public List<OrderItem> Items { get; set; }
    }
}