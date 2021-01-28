using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public User User { get; set; }
        public int Price { get; set; }
        public List<Payment> Payment { get; set; }
        public List <OrderProduct> OrderProduct { get; set; }
    }
}
