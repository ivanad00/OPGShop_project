using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Order_Product
    {
        public int order_product_id { get; set; }
        public Order order_id { get; set; }
        public Product product_id { get; set; }
    }
}
