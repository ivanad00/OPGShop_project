using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Order_Product
    {
        public int Order_Product_ID { get; set; }
        public int Order_ID { get; set; }
        public int Product_ID { get; set; }
    }
}
