using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
