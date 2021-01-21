using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Product
    {
        public int Product_ID { get; set; }
        public int User_ID { get; set; }
        public int Category_ID { get; set; }
        public string Product_Description { get; set; }
        public float Discount { get; set; }
    }
}
