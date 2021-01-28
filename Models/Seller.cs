using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        public int Oib { get; set; }
    }
}
