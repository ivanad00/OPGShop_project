using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Payment
    {
        public int payment_id { get; set; }
        public string payment_type { get; set; }
        public string allowed { get; set; }
    }
}
