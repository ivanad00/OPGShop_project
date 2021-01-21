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
        public int order_id { get; set; }
        public int arrival_time { get; set; }
        public Users user_id { get; set; }
        public Payment payment_id { get; set; }
    }
}
