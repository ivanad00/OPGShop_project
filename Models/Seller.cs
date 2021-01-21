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
        public int seller_id { get; set; }
        public Users user_id { get; set; }
        public string company_name { get; set; }
        public int oib { get; set; }
    }
}
