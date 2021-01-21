using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Order
    {
        public int Order_ID { get; set; }
        public int Arrival_Time { get; set; }
        public int Customer_ID { get; set; }
        public int Seller_ID { get; set; }
        public int Payment_ID { get; set; }
    }
}
