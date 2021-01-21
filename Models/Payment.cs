using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Payment
    {
        public int Payment_ID { get; set; }
        public string Payment_Type { get; set; }
        public string Allowed { get; set; }
    }
}
