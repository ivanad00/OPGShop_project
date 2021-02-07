using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string OrderId { get; set; }
    }
}
