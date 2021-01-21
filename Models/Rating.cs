using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Rating
    {
        public int Rating_ID { get; set; }
        public int User_ID { get; set; }
        public int Product_ID { get; set; }
        public string Note { get; set; }
    }
}
