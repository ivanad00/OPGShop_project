using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;

namespace OPG.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public Users user_id { get; set; }
        public Category category_id { get; set; }
        public string product_description { get; set; }
        public float discount { get; set; }
    }
}
