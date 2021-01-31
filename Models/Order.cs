using System;
using System.Collections.Generic;



namespace OPG.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public User User { get; set; }
        public decimal Price { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; }

    }
}